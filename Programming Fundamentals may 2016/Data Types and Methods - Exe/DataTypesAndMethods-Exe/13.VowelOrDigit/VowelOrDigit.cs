using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            ushort ascii = (ushort)input;

            switch (input)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                case 'y':
                    Console.WriteLine("vowel");
                    break;
                case 'A':
                    Console.WriteLine("vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                case 'Y':
                    Console.WriteLine("vowel");
                    break;
                default:
                    bool isItADigit = (48 <= ascii) && (ascii <= 57);
                    if (isItADigit)
                    {
                        Console.WriteLine("digit");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }
                    break;
            }
        }
    }
}
