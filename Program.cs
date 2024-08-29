using System.Globalization;
using exeptions.Entities;
using exeptions.Entities.Exceptions;
public class Program
{
    public static void Main(string[] args)
    {
        try{
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Reservation reservation= new Reservation(number, checkIn, checkOut);
        Console.WriteLine($"Reservation {reservation}");

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (dd/MM/yyyy): ");
        checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Check-out date (dd/MM/yyyy): ");
        checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine($"Reservation: {reservation}");
        }
        catch(DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch(Exception e) //captar qualquer outra excessão que não foi especificada antes.
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
    }
}