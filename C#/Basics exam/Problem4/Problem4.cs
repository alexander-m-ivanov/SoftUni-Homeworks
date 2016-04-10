using System;

class Problem4
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        decimal moneyLeft = money;
        int purchasesCounter = 0;
        int price;

        while (line != "mall.Exit")
        {
            if (line == "mall.Enter")
            {
                while (line != "mall.Exit")
                {
                    line = Console.ReadLine();
                    if (line == "mall.Exit")
                    {
                        break;
                    }
                    char[] transactions = line.ToCharArray();

                    for (int i = 0; i < transactions.Length; i++)
                    {
                        price = (int)transactions[i];
                        bool isUpperCase = (price >= 65) && (price <= 90);
                        bool isLowerCase = (price >= 97) && (price <= 122);
                        if (isUpperCase)
                        {
                            decimal transactionTotalCost = ((decimal)transactions[i] / 2);
                            if (moneyLeft < transactionTotalCost)
                            {
                                continue;
                            }
                            moneyLeft -= transactionTotalCost;
                            purchasesCounter += 1;
                        }
                        else if (isLowerCase)
                        {
                            decimal transactionTotalCost = ((decimal)transactions[i] / 100) * 30;
                            if (moneyLeft < transactionTotalCost)
                            {
                                continue;
                            }
                            moneyLeft -= transactionTotalCost;
                            purchasesCounter += 1;
                        }
                        else if (price == 37)
                        {
                            if (moneyLeft == 0)
                            {
                                continue;
                            }
                            moneyLeft /= 2;
                            purchasesCounter += 1;
                        }
                        else if (price == 42)
                        {
                            moneyLeft += 10;
                        }
                        else
                        {
                            decimal transactionTotalCost = (decimal)transactions[i];
                            if (moneyLeft < transactionTotalCost)
                            {
                                continue;
                            }
                            moneyLeft -= (decimal)transactions[i];
                            purchasesCounter += 1;
                        }
                    }
                }
            }
            else
            {
                line = Console.ReadLine();
            }
        }
        if (purchasesCounter == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:0.00} lv.", moneyLeft);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:0.00} lv.", purchasesCounter, moneyLeft);
        }
    }
}