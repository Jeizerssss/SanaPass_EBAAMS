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
            _equipmentRepository = equipmentRepository;
        }

        public bool registerEquipment(Equipment equipment)
        {
            if (equipment == null || string.IsNullOrWhiteSpace(equipment.eName))
                return false;

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
            if (equipmentID <= 0)
                return false;

            return _equipmentRepository.delete(equipmentID);
        }

        public IEnumerable<Equipment> searchAvailableEquipment(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _equipmentRepository.getAll();

            return _equipmentRepository.getByName(keyword);
        }

        public IEnumerable<Equipment> getEquipmentByCategory(int categoryID)
        {
            if (categoryID <= 0)
                return new List<Equipment>();

            return _equipmentRepository.getByCategory(categoryID);
        }
    }
}
