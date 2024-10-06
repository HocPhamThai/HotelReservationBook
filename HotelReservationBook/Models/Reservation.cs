namespace HotelReservationBook.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Length => EndDate.Subtract(StartDate);
        public Reservation(RoomID roomID, string userName, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
            UserName = userName;
        }
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }
            // Điều kiện xung đột thời gian
            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
