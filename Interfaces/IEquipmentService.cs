using SanaPass_EBAAMS.Models;
using System.Collections.Generic;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IEquipmentService
    {
        Equipment getEquipmentById(int equipmentID);
        bool registerEquipment(Equipment equipment);
        bool updateEquipmentDetails(Equipment equipment);
        bool retireEquipment(int equipmentID);
        IEnumerable<Equipment> searchAvailableEquipment(string keyword);
        IEnumerable<Equipment> getEquipmentByCategory(int categoryID);
        IEnumerable<Equipment> getAllEquipment();
    }
}
