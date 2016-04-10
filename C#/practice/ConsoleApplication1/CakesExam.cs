using System;

class CakesExam
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());          //amount of cakes Ivancho wants
        double c = double.Parse(Console.ReadLine());      //kilograms of flour needed to make one cake
        int f = int.Parse(Console.ReadLine());          //kilograms of flour available
        int t = int.Parse(Console.ReadLine());          //amount of truffles available
        int p = int.Parse(Console.ReadLine());          //price of one truffle

        double cakesAvailable = (double)f / c;
        bool areCakesEnough = cakesAvailable > n;

        if (areCakesEnough)
        {
            int truffleCost = t * p;
            double cakePrice = ((double)truffleCost / (double)n) * 1.25;

            Console.WriteLine("All products available, price of a cake: {0:0.00}", cakePrice);
        }
        else
        {
            double flourRequired = (double)n * c;
            double flourNeeded = flourRequired - f;

            Console.WriteLine(@"Can make only {0:0} cakes, need {1:0.00} kg more flour", Math.Floor(cakesAvailable), flourNeeded);
        }
    }
}