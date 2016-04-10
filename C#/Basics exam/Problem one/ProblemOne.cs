using System;

class ProblemOne
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal dollarRate = decimal.Parse(Console.ReadLine());

        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());

        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

        decimal pizzaMoneyNeeded = (pizzaPrice / dollarRate) * pizzaQuantity;
        decimal lasagnaMoneyNeeded = (lasagnaPrice / dollarRate) * lasagnaQuantity;
        decimal sanswichMoneyNeeded = (sandwichPrice / dollarRate) * sandwichQuantity;

        decimal moneyNeeded = pizzaMoneyNeeded + lasagnaMoneyNeeded + sanswichMoneyNeeded;

        bool areMoneyEnough = moneyNeeded <= money;

        if (areMoneyEnough)
        {
            decimal moneyLeft = money - moneyNeeded;
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.", moneyLeft);
        }
        else
        {
            decimal stillMoneyNecessary = moneyNeeded - money;
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.", stillMoneyNecessary);
        }
    }
}