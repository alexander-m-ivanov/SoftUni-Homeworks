using System;

namespace _10.CenturiesToNanosec
{
    class CenturiesToNanosec
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.Write("{0} centuries = {1} years = ",centuries, years);
            Console.Write("{0} days = {1} hours = ", days, hours);
            Console.Write("{0} minutes = {1} seconds = ", minutes, seconds);
            Console.Write("{0} milliseconds = {1} microseconds = ",milliseconds, microseconds);
            Console.Write("{0} nanoseconds", nanoseconds);
        }
    }
}
