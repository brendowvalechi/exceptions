using System.Globalization;
using System.Net.Mail;
using exeptions.Entities;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after Check-in date.");
        }
        else
        {
        Reservation reservation= new Reservation(number, checkIn, checkOut);
        Console.WriteLine($"Reservation {reservation}");

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (dd/MM/yyyy): ");
        checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Check-out date (dd/MM/yyyy): ");
        checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            Console.WriteLine("Error in reservation: Reservation dates for update must");
        }

        }
    }
}