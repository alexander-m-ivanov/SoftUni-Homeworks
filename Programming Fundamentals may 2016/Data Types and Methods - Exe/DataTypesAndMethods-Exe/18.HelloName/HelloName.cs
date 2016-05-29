using System;

namespace _18.HelloName
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
