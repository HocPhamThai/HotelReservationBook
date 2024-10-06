using HotelReservationBook.Exceptions;
using HotelReservationBook.Models;
using System.Windows;

namespace HotelReservationBook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Happy Hour!!!");
            try
            {
                hotel.MakeReservation(new Reservation
                (
                    new RoomID(1, 1),
                    "HocPham",
                    new DateTime(2022, 1, 1),
                    new DateTime(2022, 1, 2)
                ));
                hotel.MakeReservation(new Reservation
                (
                    new RoomID(1, 1),
                    "HocPham",
                    new DateTime(2022, 1, 1),
                    new DateTime(2022, 1, 4)
                ));
            }
            catch (ReservationConflictException ex)
            {

            }


            IEnumerable<Reservation> reservations = hotel.GetReservationToUser("HocPham");

            base.OnStartup(e);
        }
    }

}
