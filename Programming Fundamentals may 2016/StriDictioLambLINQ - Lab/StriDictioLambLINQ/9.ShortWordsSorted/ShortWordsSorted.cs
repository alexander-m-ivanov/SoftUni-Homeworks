using System;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();
        string[] words = Console.ReadLine().ToLower().Split(separators);

        string[] removeSpaces = words.Where(x => x != "").ToArray();
        string[] wordsLessThan5Char = removeSpaces.Where(w => w.Length < 5).ToArray();
        string[] orderWords= wordsLessThan5Char.OrderBy(word => word).ToArray();
        string[] removeDuplicates = orderWords.Distinct().ToArray();

        Console.WriteLine(string.Join(", ", removeDuplicates));
    }
}