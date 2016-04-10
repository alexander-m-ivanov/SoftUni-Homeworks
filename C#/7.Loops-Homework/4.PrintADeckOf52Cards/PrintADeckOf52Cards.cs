using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i <= 10)
            {
                Console.Write(i + "{0} ", (char)5);
                Console.Write(i + "{0} ", (char)4);
                Console.Write(i + "{0} ", (char)3);
                Console.WriteLine(i + "{0} ", (char)6);
            }
            else
            {
                for (int j = 3; j < 7; j++)
                {
                    switch (j)
                    {
                        case 3:
                            Console.Write("J" + "{0} ", (char)5);
                            Console.Write("J" + "{0} ", (char)4);
                            Console.Write("J" + "{0} ", (char)3);
                            Console.WriteLine("J" + "{0} ", (char)6);
                            break;
                        case 4:
                            Console.Write("Q" + "{0} ", (char)5);
                            Console.Write("Q" + "{0} ", (char)4);
                            Console.Write("Q" + "{0} ", (char)3);
                            Console.WriteLine("Q" + "{0} ", (char)6);
                            break;
                        case 5:
                            Console.Write("K" + "{0} ", (char)5);
                            Console.Write("K" + "{0} ", (char)4);
                            Console.Write("K" + "{0} ", (char)3);
                            Console.WriteLine("K" + "{0} ", (char)6);
                            break;
                        case 6:
                            Console.Write("A" + "{0} ", (char)5);
                            Console.Write("A" + "{0} ", (char)4);
                            Console.Write("A" + "{0} ", (char)3);
                            Console.WriteLine("A" + "{0} ", (char)6);
                            break;
                    }

                }
            }
        }
    }
}