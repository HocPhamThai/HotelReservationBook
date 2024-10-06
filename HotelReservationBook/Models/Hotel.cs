namespace HotelReservationBook.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotel(string name)
        {
            _reservationBook = new ReservationBook();
            Name = name;
        }
        public IEnumerable<Reservation> GetReservationToUser(string username)
        {
            return _reservationBook.GetReservationForUser(username);
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
