using System;

class BeerTime
{
    static void Main()
    {
        try
        {
            string time = Console.ReadLine();
            int timeCharCount = time.Length;

            if (timeCharCount == 8) //for format "hh:mm tt"
            {
                DateTime dateTime = DateTime.ParseExact(time, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);

                int timeHour = dateTime.Hour;
                int timeMinute = dateTime.Minute;
                string[] timeSeparate = time.Split(' ');
                string timeDesignator = timeSeparate[1];

                bool isItBeerTimePM = (((timeHour >= 13) && (timeHour < 24)) && ((timeMinute >= 0) && (timeMinute <= 59)) &&
                    ((timeDesignator == "PM") || (timeDesignator == "pm") || (timeDesignator == "Pm") || (timeDesignator == "pM")));
                bool isItBeerTimeAM = (((timeHour >= 0) && (timeHour <= 2)) && ((timeMinute >= 0) && (timeMinute <= 59)) &&
                    ((timeDesignator == "AM") || (timeDesignator == "am") || (timeDesignator == "Am") || (timeDesignator == "aM")));
                bool isItBeerTimeAtAll = isItBeerTimePM || isItBeerTimeAM;

                if (isItBeerTimeAtAll)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else //for format "h:mm tt"
            {
                DateTime dateTime = DateTime.ParseExact(time, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);

                int timeHour = dateTime.Hour;
                int timeMinute = dateTime.Minute;
                string[] timeSeparate = time.Split(' ');
                string timeDesignator = timeSeparate[1];

                bool isItBeerTimePM = (((timeHour >= 13) && (timeHour < 24)) && ((timeMinute >= 0) && (timeMinute <= 59)) &&
                                      ((timeDesignator == "PM") || (timeDesignator == "pm") || (timeDesignator == "Pm") || (timeDesignator == "pM")));
                bool isItBeerTimeAM = (((timeHour >= 0) && (timeHour <= 2)) && ((timeMinute >= 0) && (timeMinute <= 59)) &&
                                      ((timeDesignator == "AM") || (timeDesignator == "am") || (timeDesignator == "Am") || (timeDesignator == "aM")));
                bool isItBeerTimeAtAll = isItBeerTimePM || isItBeerTimeAM;

                if (isItBeerTimeAtAll)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
        }
    }
}