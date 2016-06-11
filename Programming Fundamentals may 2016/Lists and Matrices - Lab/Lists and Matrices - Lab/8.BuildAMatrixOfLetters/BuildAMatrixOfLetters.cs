using System;

class BuildAMatrixOfLetters
{
    static void Main()
    {
        int numberOfRaws = int.Parse(Console.ReadLine());
        int numberOfColumns = int.Parse(Console.ReadLine());

        char letter = 'A';
        char[][] matrix = new char[numberOfRaws][];
        for (int raw = 0; raw < numberOfRaws; raw++)
        {
            matrix[raw] = new char[numberOfColumns];
            for (int column = 0; column < numberOfColumns; column++)
            {
                matrix[raw][column] = letter;
                letter++;
            }
        }
        foreach (var raw in matrix)
        {
            Console.WriteLine(string.Join(" ", raw));
        }
    }
}