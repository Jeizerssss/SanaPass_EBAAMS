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

        public int getAvailableEquipmentCount()
        {
            return _equipmentRepository.getAll().Count(e =>
                string.Equals(e.eStatus, "Available", StringComparison.OrdinalIgnoreCase));
        }

        public string buildBusinessSummary()
        {
            var requests = _requestRepository.getAll().ToList();
            var equipment = _equipmentRepository.getAll().ToList();
            var maintenanceItems = _maintenanceRepository.getAll().ToList();

            var summary = new StringBuilder();
            summary.AppendLine("SanaPass EBAAMS Business Summary");
            summary.AppendLine("Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            summary.AppendLine();
            summary.AppendLine("Total equipment: " + equipment.Count);
            summary.AppendLine("Available equipment: " + equipment.Count(item => item.eStatus == "Available"));
            summary.AppendLine("Pending requests: " + requests.Count(request =>
                request.rStatus == "Pending" || request.rStatus == "Pending Approval" || request.rStatus == "Pending Release"));
            summary.AppendLine("Active borrows: " + requests.Count(request => request.rStatus == "Pending Return"));
            summary.AppendLine("Maintenance records: " + maintenanceItems.Count);

            return summary.ToString();
        }
    }
}
