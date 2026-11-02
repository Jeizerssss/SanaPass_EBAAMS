using System;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IBorrowService
    {
        bool submitBorrowRequest(
            int userID,
            int equipmentID,
            string rLocation,
            string rDesc);
        bool approveRequest(int requestID, int handledBy);
        bool releaseEquipment(int requestID, int handledBy);
        bool processReturn(
            int requestID,
            int handledBy,
            string eCondition,
            DateTime returnDate);
    }
}
