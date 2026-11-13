
using System;

class Program
{
    static void Main()
    {
        int nomer = 1;
        int n = 5;

        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix);

        int[] result = FindNegativeRows(matrix);

        Console.WriteLine("\nResult array B:");

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("B[" + i + "] = " + result[i]);
        }
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    static int[] FindNegativeRows(int[,] m)
    {
        int rows = m.GetLength(0);
        int columns = m.GetLength(1);

        int[] B = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            bool hasNegative = false;

            for (int j = 0; j < columns; j++)
            {
                if (m[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
            }

            B[i] = hasNegative ? 1 : 0;
        }

        return B;
    }
}
