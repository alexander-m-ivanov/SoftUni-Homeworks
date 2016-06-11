using System;
using System.Collections.Generic;
using System.Linq;

class MatrixOfPalindromes
{
    static void Main()
    {
        int[] matrixParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberOfRaws = matrixParameters[0];
        int numberOfcolumns = matrixParameters[1];

        char letter = 'a';
        char[][][] matrix = new char[numberOfRaws][][];

        for (int raw = 0; raw < numberOfRaws; raw++)
        {
            matrix[raw] = new char[numberOfcolumns][];
            for (int column = 0; column < numberOfcolumns; column++)
            {
                matrix[raw][column] = new char[3];
                for (int charColumn = 0; charColumn < 3; charColumn++)
                {
                    if (charColumn == 0 || charColumn == 2)
                    {
                        matrix[raw][column][charColumn] = (char) ((int) letter + raw);
                    }
                    else
                    {
                        matrix[raw][column][charColumn] = (char)((int)letter + column + raw);
                    }
                }
            }
        }

        for (int raw = 0; raw < numberOfRaws; raw++)
        {
            for (int column = 0; column < numberOfcolumns; column++)
            {
                for (int charColumn = 0; charColumn < 3; charColumn++)
                {
                      Console.Write(matrix[raw][column][charColumn]);
                }

                if (column == numberOfcolumns - 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}