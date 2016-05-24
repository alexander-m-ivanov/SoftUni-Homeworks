using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allTimeInSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            float allTimeInHours = ((seconds / 60) / 60) + (minutes / 60) + hours;
            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / 1609;

            Console.WriteLine(distanceInMeters / allTimeInSeconds);
            Console.WriteLine(distanceInKilometers / allTimeInHours);
            Console.WriteLine(distanceInMiles / allTimeInHours);
        }
    }
}
