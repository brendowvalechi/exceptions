using exceptions.Entities.Exceptions;

namespace exceptions.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
            throw new DomainException("Check-out date must be after Check-in date.");
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
        if (checkIn < now || checkOut < now)
        {
           throw new DomainException("Reservation dates for update must be future dates."); //Lança uma instancia de DomainException para anunciar a exceção
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-out date must be after Check-in date.");
        }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
            + RoomNumber
            + ", Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights.";
        }

    }
}