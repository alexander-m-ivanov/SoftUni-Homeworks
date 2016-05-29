using System;

class DayOfWeek
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());

        string[] weekDays = {"Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        if (day >= 1 && day <= 7)
        {
            Console.WriteLine(weekDays[day]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}
