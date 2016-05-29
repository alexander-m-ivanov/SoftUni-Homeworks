using System;
using System.Linq;

class ExtractMiddle12Or3Elements
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');

        bool isStrLenght1 = str.Length == 1;
        bool isStrLenghtEven = str.Length % 2 == 0;

        if (isStrLenght1)
        {
            Console.WriteLine("{ " + str[0] + " }");
        }
        if (isStrLenghtEven)
        {
            string n1 = str[(str.Length / 2) - 1];
            string n2 = str[str.Length / 2];

            Console.WriteLine("{ " + n1 + ", " + n2 + " }");
        }
        else if (!isStrLenghtEven && !isStrLenght1)
        {
            string n1 = str[(str.Length / 2) - 1];
            string n2 = str[str.Length / 2];
            string n3 = str[(str.Length / 2) + 1];

            Console.WriteLine("{ " + n1 + ", " + n2 + ", " + n3 + " }");
        }
    }
}