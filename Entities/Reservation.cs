using System;

namespace Workspace.Entities;

public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.TotalDays;
    }

    public string UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;

        if (checkIn < now || checkOut < now)
        {
            return "Reservation dates for update must be future dates";
        }

        if (checkOut <= checkIn)
        {
            return "Check-out date must be after check-in";
        }

        CheckIn = checkIn;
        CheckOut = checkOut;
        return null;
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
                + " nights";
    }
}
