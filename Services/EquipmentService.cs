using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository ?? throw new ArgumentNullException(nameof(equipmentRepository));
        }

        public bool registerEquipment(Equipment equipment)
        {
            if (equipment == null || string.IsNullOrWhiteSpace(equipment.eName))
                return false;

            equipment.eStatus = "Available";
            return _equipmentRepository.add(equipment);
        }

        public bool updateEquipmentDetails(Equipment equipment)
        {
            if (equipment == null || equipment.equipmentID <= 0)
                return false;

            return _equipmentRepository.update(equipment);
        }

        public bool retireEquipment(int equipmentID)
        {
            var equipment = _equipmentRepository.getById(equipmentID);
            if (equipment == null) return false;

            equipment.eStatus = "Retired";
            equipment.eQuantity = 0;
            return _equipmentRepository.update(equipment);
        }

        public IEnumerable<Equipment> searchAvailableEquipment(string keyword)
        {
            var all = _equipmentRepository.getAll();
            if (string.IsNullOrWhiteSpace(keyword))
                return all.Where(e => e.eStatus == "Available" && e.eQuantity > 0);

            return all.Where(e => e.eStatus == "Available"
                                && e.eQuantity > 0
                                && e.eName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public IEnumerable<Equipment> getEquipmentByCategory(int categoryID)
        {
            return _equipmentRepository.getByCategory(categoryID);
        }
    }
}
