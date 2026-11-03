using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanaPass_EBAAMS.Services
{
    public class ReportService : IReportService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IMaintenanceRepository _maintenanceRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ReportService(
            IRequestRepository requestRepository,
            IEquipmentRepository equipmentRepository,
            IMaintenanceRepository maintenanceRepository,
            ICategoryRepository categoryRepository)
        {
            _requestRepository =
                requestRepository
                ?? throw new ArgumentNullException(nameof(requestRepository));

            _equipmentRepository =
                equipmentRepository
                ?? throw new ArgumentNullException(nameof(equipmentRepository));

            _maintenanceRepository =
                maintenanceRepository
                ?? throw new ArgumentNullException(nameof(maintenanceRepository));

            _categoryRepository =
                categoryRepository
                ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public Dictionary<string, int> getMonthlyBorrowTrends()
        {
            IEnumerable<Request> requests =
                _requestRepository.getAll()
                ?? Enumerable.Empty<Request>();

            return requests
                .GroupBy(request => request.rDate.ToString("MMM"))
                .OrderBy(group => group.Min(request => request.rDate.Month))
                .ToDictionary(
                    group => group.Key,
                    group => group.Count());
        }

        public Dictionary<string, int> getEquipmentCountByCategory()
        {
            IEnumerable<Category> categories =
                _categoryRepository.getAll()
                ?? Enumerable.Empty<Category>();

            Dictionary<string, int> result =
                new Dictionary<string, int>();

            foreach (Category category in categories)
            {
                string categoryName =
                    string.IsNullOrWhiteSpace(category.cName)
                        ? "Uncategorized"
                        : category.cName;

                IEnumerable<Equipment> equipment =
                    _equipmentRepository.getByCategory(
                        category.categoryID)
                    ?? Enumerable.Empty<Equipment>();

                result[categoryName] = equipment.Count();
            }

            return result;
        }

        public int getPendingRequestsCount()
        {
            IEnumerable<Request> requests =
                _requestRepository.getAll()
                ?? Enumerable.Empty<Request>();

            return requests.Count(request =>
                IsStatus(request.rStatus, "Pending") ||
                IsStatus(request.rStatus, "Pending Approval") ||
                IsStatus(request.rStatus, "Pending Release"));
        }

        public int getBorrowedItemsCount()
        {
            IEnumerable<Request> requests =
                _requestRepository.getAll()
                ?? Enumerable.Empty<Request>();

            return requests.Count(request =>
                IsStatus(request.rStatus, "Issued") ||
                IsStatus(request.rStatus, "Pending Return"));
        }

        public int getOverdueReturnCount()
        {
            DateTime overdueThreshold =
                DateTime.Now.AddDays(-3);

            IEnumerable<Request> requests =
                _requestRepository.getAll()
                ?? Enumerable.Empty<Request>();

            return requests.Count(request =>
                (IsStatus(request.rStatus, "Issued") ||
                 IsStatus(request.rStatus, "Pending Return")) &&
                request.rDate < overdueThreshold);
        }

        public int getMaintenanceItemsCount()
        {
            IEnumerable<Equipment> equipment =
                _equipmentRepository.getAll()
                ?? Enumerable.Empty<Equipment>();

            return equipment.Count(item =>
                IsStatus(item.eStatus, "Under Maintenance"));
        }

        public int getAvailableEquipmentCount()
        {
            IEnumerable<Equipment> equipment =
                _equipmentRepository.getAll()
                ?? Enumerable.Empty<Equipment>();

            return equipment.Count(item =>
                IsStatus(item.eStatus, "Available"));
        }

        public string buildBusinessSummary()
        {
            StringBuilder summary =
                new StringBuilder();

            summary.AppendLine("Business Summary Report");
            summary.AppendLine(
                "Generated on: " + DateTime.Now);
            summary.AppendLine();

            summary.AppendLine(
                "Total Pending Requests: " +
                getPendingRequestsCount());

            summary.AppendLine(
                "Total Borrowed Items: " +
                getBorrowedItemsCount());

            summary.AppendLine(
                "Total Available Equipment: " +
                getAvailableEquipmentCount());

            summary.AppendLine(
                "Total Maintenance Items: " +
                getMaintenanceItemsCount());

            summary.AppendLine();
            summary.AppendLine("Monthly Borrow Trends:");

            foreach (KeyValuePair<string, int> trend
                in getMonthlyBorrowTrends())
            {
                summary.AppendLine(
                    trend.Key + ": " + trend.Value);
            }

            summary.AppendLine();
            summary.AppendLine("Equipment Count by Category:");

            foreach (KeyValuePair<string, int> category
                in getEquipmentCountByCategory())
            {
                summary.AppendLine(
                    category.Key + ": " + category.Value);
            }

            return summary.ToString();
        }

        private static bool IsStatus(
            string actualStatus,
            string expectedStatus)
        {
            return string.Equals(
                actualStatus,
                expectedStatus,
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
