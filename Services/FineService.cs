using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class FineService : IFineService
    {
        private readonly IFineRepository _fineRepository;
        private readonly IRequestRepository _requestRepository;
        private readonly IPaymentHistoryRepository _paymentHistoryRepository;
        private readonly ITransactionLogRepository _transactionLogRepository;

        public FineService(
            IFineRepository fineRepository,
            IRequestRepository requestRepository,
            IPaymentHistoryRepository paymentHistoryRepository,
            ITransactionLogRepository transactionLogRepository)
        {
            _fineRepository = fineRepository ?? throw new ArgumentNullException(nameof(fineRepository));
            _requestRepository = requestRepository ?? throw new ArgumentNullException(nameof(requestRepository));
            _paymentHistoryRepository = paymentHistoryRepository ?? throw new ArgumentNullException(nameof(paymentHistoryRepository));
            _transactionLogRepository = transactionLogRepository ?? throw new ArgumentNullException(nameof(transactionLogRepository));
        }

        public double calculateOverdueFine(int requestID, DateTime returnDate, double dailyRate)
        {
            var request = _requestRepository.getById(requestID);
            if (request == null) return 0.0;

            // Simple business logic: Overdue if return date exceeds request date by more than 3 days
            int allowedDays = 3;
            TimeSpan duration = returnDate - request.rDate;
            int overdueDays = (int)Math.Ceiling(duration.TotalDays) - allowedDays;

            if (overdueDays <= 0)
            {
                return 0.0;
            }

            double calculatedAmount = overdueDays * dailyRate;

            var fine = new Fine
            {
                fDate = DateTime.Now,
                requestID = requestID,
                amount = calculatedAmount,
                fineStatus = "Unpaid"
            };

            _fineRepository.add(fine);
            return calculatedAmount;
        }

        public bool processFinePayment(int requestID, double amountReceived, string pType, int handledBy)
        {
            var request = _requestRepository.getById(requestID);

            if (request == null)
            {
                return false;
            }

            var fine = _fineRepository.getByRequestId(requestID);

            if (fine == null || fine.fineStatus == "Paid")
            {
                return false;
            }

            double remainingBalance = fine.amount - amountReceived;

            if (remainingBalance < 0)
            {
                remainingBalance = 0;
            }

            var paymentHistory = new PaymentHistory
            {
                pDate = DateTime.Now,
                userID = request.userID,
                pHType = pType,
                accountBalance = fine.amount,
                amountReceived = amountReceived,
                remainingBalance = remainingBalance
            };

            if (!_paymentHistoryRepository.add(paymentHistory))
            {
                return false;
            }

            string updatedStatus = remainingBalance == 0 ? "Paid" : "Partial";
            _fineRepository.updateStatus(fine.fineID, updatedStatus);

            _transactionLogRepository.add(new TransactionLog
            {
                tlDate = DateTime.Now,
                requestID = requestID,
                handledBy = handledBy,
                tlType = "FINE_PAYMENT_RECEIVED"
            });

            return true;
        }
    }
}
