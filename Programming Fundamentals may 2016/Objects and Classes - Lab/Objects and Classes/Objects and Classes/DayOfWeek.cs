using System;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {
        DateTime date = new DateTime();
        bool isValid = DateTime.TryParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

        Console.WriteLine(date.DayOfWeek);
    }
}