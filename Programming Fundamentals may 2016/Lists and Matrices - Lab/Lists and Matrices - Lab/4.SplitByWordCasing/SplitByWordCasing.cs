using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main()
    {
        char[] separators = new char[] {' ', ',', ';', ':', '.', '!', '(', ')', '"',  '\'',  '\\',  '/', '[', ']'};

        List<string> words = Console.ReadLine().Split(separators).ToList();
        words.RemoveAll(x => x == "");

        List<string> lowerCase = new List<string>();
        List<string> mixedCase = new List<string>();
        List<string> upperCase = new List<string>();
        int upperCaseCounter = 0;
        int lowerCaseCounter = 0;
        int otherCharCounter = 0;

        for (int i = 0; i < words.Count; i++)
        {
            upperCaseCounter = 0;
            lowerCaseCounter = 0;
            otherCharCounter = 0;

            char[] array = words[i].ToCharArray();

            for (int j = 0; j < array.Length; j++)
            {
                int asciiCharCode = array[j];
                bool isCharLowerCase = 97 <= asciiCharCode && asciiCharCode <= 122;
                bool isUpperLowerCase = 65 <= asciiCharCode && asciiCharCode <= 90;

                if (isCharLowerCase)
                {
                    lowerCaseCounter += 1;
                }
                else if (isUpperLowerCase)
                {
                    upperCaseCounter += 1;
                }
                else
                {
                    otherCharCounter += 1;
                }
            }

            bool isWordLowerCase = lowerCaseCounter > 0 && upperCaseCounter == 0 && otherCharCounter == 0;
            bool isWordUpperCase = lowerCaseCounter == 0 && upperCaseCounter > 0 && otherCharCounter == 0;

            if (isWordLowerCase)
            {
                lowerCase.Add(words[i]);
            }
            else if (isWordUpperCase)
            {
                upperCase.Add(words[i]);
            }
            else
            {
                mixedCase.Add(words[i]);
            }
        }
        Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
    }
}