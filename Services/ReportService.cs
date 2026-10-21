using SanaPass_EBAAMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .GroupBy(r => r.date.ToString("MMM"))
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
            return _requestRepository.getByStatus("Pending").Count();
        }

        public int getBorrowedItemsCount()
        {
            return _requestRepository.getByStatus("Issued").Count();
        }

        public int getMaintenanceItemsCount()
        {
            return _equipmentRepository.getAll().Count(e => e.eStatus == "Under Maintenance");
        }
    }
}
