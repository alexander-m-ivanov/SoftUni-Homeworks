using System;
using System.Globalization;

class SoftUniCoffeeOrders
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine()); ;
        decimal pricePerCapsule = 0;
        string orderDate = "";
        DateTime formatedDateTime = new DateTime();
        decimal capsulesCount = 0;
        decimal daysInMonth = 0;
        decimal[] cofeePrice = new decimal[orders];
        decimal total = 0;

        for (int i = 0; i < orders; i++)
        {
            pricePerCapsule = decimal.Parse(Console.ReadLine());
            orderDate = Console.ReadLine();
            formatedDateTime = DateTime.ParseExact(orderDate, "d/MM/yyyy", CultureInfo.InvariantCulture);
            daysInMonth = DateTime.DaysInMonth(formatedDateTime.Year, formatedDateTime.Month);
            capsulesCount = decimal.Parse(Console.ReadLine());

            cofeePrice[i] = (daysInMonth * capsulesCount) * pricePerCapsule;

            total += cofeePrice[i];
        }

        for (int i = 0; i < orders; i++)
        {
            Console.WriteLine("The price for the coffee is: ${0:f2}", cofeePrice[i]);
        }

        Console.WriteLine("Total: ${0:f2}", total);
    }
}