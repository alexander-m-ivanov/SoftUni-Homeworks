using System;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] integersUntilN = new int[n - 1];
        int[] markedIntegers = integersUntilN;
        int[] containPrimes = new int[n - 1];
        //containPrimes[0] = 2;

        int p = 2;
        int counter = 0;
        int counter3 = 0;
        int counter5 = 0;
        int counter6 = 0;

        if ((n == 1) || (n == 0))
        {
            Console.Write("");
        }
        else if (n == 2)
        {
            Console.Write(2);
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                integersUntilN[i] = i + 2;
            }

            int counter4 = integersUntilN[0];

            while (p < n)
            {
                for (int j = p * counter4; j <= n; j = p * counter4)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        bool shouldItbeMarked = markedIntegers[k] == j;

                        if (shouldItbeMarked)
                        {
                            markedIntegers[k] = 0;
                        }
                    }
                    counter4++;
                }

                counter4 = 2;

                for (int i = 0; i < integersUntilN.Length; i++)
                {
                    bool howManyIntegersAreLeft = markedIntegers[i] != 0;

                    if (howManyIntegersAreLeft)
                    {
                        counter += 1;
                    }
                }

                for (int i = 0; i < integersUntilN.Length; i++)
                {
                    for (int j = 0; j < integersUntilN.Length; j++)
                    {
                        bool whichIntegersAreLeft = integersUntilN[i] == markedIntegers[j];

                        if (whichIntegersAreLeft)
                        {
                            containPrimes[i] = integersUntilN[i];
                        }
                    }
                }

                int lastP = p;
                p = containPrimes[counter3 + 1];
                int counter7 = 0;
                while (p == 0)
                {
                    if (containPrimes[counter3 + 1] == 0)
                    {
                        counter7 += 1;
                        p = containPrimes[counter3 + counter7];
                    }
                }
                counter7 = 0;

                if (p == lastP)
                {
                    p = p * n;
                }
                counter3 += 1;
                counter = 0;

            }

            for (int i = 0; i < containPrimes.Length; i++)
            {
                if (containPrimes[i] != 0)
                {
                    counter5 += 1;
                }
            }

            int[] printPrimes = new int[counter5];

            for (int j = 0; j < containPrimes.Length; j++)
            {
                if (containPrimes[j] != 0)
                {
                    printPrimes[counter6] = containPrimes[j];
                    counter6 += 1;
                }
            }

            for (int i = 0; i < printPrimes.Length; i++)
            {
                if (printPrimes.Length - 1 == i)
                {
                    Console.Write(printPrimes[i]);
                }
                else
                {
                    Console.Write(printPrimes[i] + " ");
                }
            }
        }
    }
}   