using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        //first solution
        Console.OutputEncoding = Encoding.UTF8;
        char symb = '\u00A9';
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}\n", symb);

        //second solution
        Console.WriteLine("   {0}   ", symb);
        Console.WriteLine("  {0} {1}", symb, symb);
        Console.WriteLine(" {0}   {1}", symb, symb);
        Console.WriteLine("{0} {1} {2} {3}", symb, symb, symb, symb);

    }

}