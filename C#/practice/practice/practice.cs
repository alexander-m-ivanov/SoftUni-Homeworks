using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int element = 0; element < names.Length; element++)
            {
                names[element] = Console.ReadLine();
            }

            Console.WriteLine(Environment.NewLine);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
