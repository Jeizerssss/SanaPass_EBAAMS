using System.Collections.Generic;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IReportService
    {
        Dictionary<string, int> getMonthlyBorrowTrends();
        Dictionary<string, int> getEquipmentCountByCategory();
        int getPendingRequestsCount();
        int getBorrowedItemsCount();
        int getMaintenanceItemsCount();
        string buildBusinessSummary();
    }
}
