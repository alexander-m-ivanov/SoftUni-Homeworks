using System;

class BonusScore
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if ((n >= 1) && (n <= 9))
        {
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(n * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(n * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(n *1000);
                    break;
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}