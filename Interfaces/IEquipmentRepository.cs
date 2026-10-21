using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IEquipmentRepository : ICrudRepository<Equipment, int>
    {
        IEnumerable<Equipment> getByCategory(int categoryID);
        IEnumerable<Equipment> getByLocation(int locationID);
        bool updateQuantity(int equipmentID, int newQuantity);
        bool updateStatus(int equipmentID, string eStatus);
    }
}
