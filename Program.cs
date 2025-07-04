using System;
using Workspace.Entities;
using Workspace.Entities.Exceptions;

namespace Workspace;

public class ProcessFile
{
    public static void Main()
    {
        try
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());
            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
        }
        catch (DomainException e)
        {
            Console.Write("Error in reservation: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.Write("Format error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.Write("Unexpected error: " + e.Message);
        }
    }
}
