using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IEquipmentService
    {
        bool registerEquipment(Equipment equipment);
        bool updateEquipmentDetails(Equipment equipment);
        bool retireEquipment(int equipmentID);
        IEnumerable<Equipment> searchAvailableEquipment(string keyword);
        IEnumerable<Equipment> getEquipmentByCategory(int categoryID);
    }
}
