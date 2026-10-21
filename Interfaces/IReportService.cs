using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IReportService
    {
        Dictionary<string, int> getMonthlyBorrowTrends();
        Dictionary<string, int> getEquipmentCountByCategory();
        int getPendingRequestsCount();
        int getBorrowedItemsCount();
        int getMaintenanceItemsCount();
    }
}
