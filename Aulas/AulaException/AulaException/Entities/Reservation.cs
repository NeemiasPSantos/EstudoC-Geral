using AulaException.Entities.Exception;

namespace AulaException.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (CheckOut <= CheckIn)
            {
                throw new DomainException("Check-out date must be check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (CheckIn < now || CheckOut < now)
            {
                throw new DomainException ("Reservation dates for update must be future dates");
            }
            if (CheckOut <= CheckIn)
            {
                throw new DomainException("Check-out date must be check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " night";
        }
    }
}
