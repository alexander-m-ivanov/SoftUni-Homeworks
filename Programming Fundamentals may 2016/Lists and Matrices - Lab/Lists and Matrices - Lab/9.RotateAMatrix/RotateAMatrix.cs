using System;

class RotateAMatrix
{
    static void Main()
    {
        int numberOfRaws = int.Parse(Console.ReadLine());
        int numberOfColumns = int.Parse(Console.ReadLine());

        string[][] matrix = new string[numberOfRaws][];

        for (int raw = 0; raw < numberOfRaws; raw++)
        {
            matrix[raw] = Console.ReadLine().Split(' ');
        }

        for (int column = 0; column < numberOfColumns; column++)
        {
            for (int row = numberOfRaws - 1; row >= 0; row--)
            {
                Console.Write(matrix[row][column] + " ");
            }
            Console.WriteLine();
        }
    }
}