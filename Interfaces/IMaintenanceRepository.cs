using System;
using SanaPass_EBAAMS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IMaintenanceRepository : ICrudRepository<Maintenance, int>
    {
        IEnumerable<Maintenance> getByEquipmentId(int equipmentID);
        IEnumerable<Maintenance> getByStatus(string mStatus);
        bool updateStatus(int mID, string mStatus);
    }
}
