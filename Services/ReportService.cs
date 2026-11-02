using SanaPass_EBAAMS.Interfaces;
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
            _requestRepository = requestRepository;
            _equipmentRepository = equipmentRepository;
            _maintenanceRepository = maintenanceRepository;
            _categoryRepository = categoryRepository;
        }

        public Dictionary<string, int> getMonthlyBorrowTrends()
        {
            var requests = _requestRepository.getAll();
            return requests
                .GroupBy(r => r.rDate.ToString("MMM"))
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<string, int> getEquipmentCountByCategory()
        {
            var categories = _categoryRepository.getAll();
            var result = new Dictionary<string, int>();

            foreach (var cat in categories)
            {
                int count = _equipmentRepository.getByCategory(cat.categoryID).Count();
                result.Add(cat.cName, count);
            }

            return result;
        }

        public int getPendingRequestsCount()
        {
            return _requestRepository.getAll().Count(request =>
                request.rStatus == "Pending" ||
                request.rStatus == "Pending Approval" ||
                request.rStatus == "Pending Release");
        }

        public int getBorrowedItemsCount()
        {
            return _requestRepository.getAll().Count(request =>
                request.rStatus == "Issued" || request.rStatus == "Pending Return");
        }

        public int getOverdueReturnCount()
        {
            DateTime overdueThreshold = DateTime.Now.AddDays(-3);
            return _requestRepository.getAll().Count(request =>
                (request.rStatus == "Issued" || request.rStatus == "Pending Return") &&
                request.rDate < overdueThreshold);
        }

        public int getMaintenanceItemsCount()
        {
            return _equipmentRepository.getAll().Count(e => e.eStatus == "Under Maintenance");
        }
        public string buildBusinessSummary()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Business Summary Report");
            sb.AppendLine($"Generated on: {DateTime.Now}");
            sb.AppendLine();
            sb.AppendLine($"Total Pending Requests: {getPendingRequestsCount()}");
            sb.AppendLine($"Total Borrowed Items: {getBorrowedItemsCount()}");
            sb.AppendLine($"Total Maintenance Items: {getMaintenanceItemsCount()}");
            sb.AppendLine();
            sb.AppendLine("Monthly Borrow Trends:");
            foreach (var trend in getMonthlyBorrowTrends())
            {
                sb.AppendLine($"{trend.Key}: {trend.Value}");
            }
            sb.AppendLine();
            sb.AppendLine("Equipment Count by Category:");
            foreach (var category in getEquipmentCountByCategory())
            {
                sb.AppendLine($"{category.Key}: {category.Value}");
            }
            return sb.ToString();
        }
    }
}
