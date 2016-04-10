using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1:
                {
                    Console.Write("Please enter an int: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                }
        }

    }
}