using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work No. 5");
            Console.Write("\nEhter the N: ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Ehter the M: ");
            int M = Int32.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] arr = new int[N, M];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    /*Console.Write("Ehter the element " + "[" + (i + 1) + "," + (j + 1) + "]: ");
                    arr[i,j] = Int32.Parse(Console.ReadLine());*/
                    arr[i, j] = rand.Next(100);
                }
            }

            Output(arr);

            int min = arr[0, 0], max = arr[0, 0];
            int indexMinX = 0, indexMaxY = 0, indexMinY = 0, indexMaxX = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        indexMinX = i;
                        indexMinY = j;
                    }

                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        indexMaxX = i;
                        indexMaxY = j;
                    }
                }
            }
            Console.WriteLine("\nDelete rows (0) and columns (1)?");
            Console.Write("Your choice:");

            int select = Int32.Parse(Console.ReadLine());

            switch (select)
            {
                case 0:
                    Console.WriteLine("\nRemoved row with minimal element " + min + ":");
                    arr = DeleteRow(arr, indexMinX);
                    Output(arr);

                    if (indexMinX != indexMaxX)
                    {
                        if (indexMaxX != 0 && indexMaxX > indexMinX) indexMaxX--;
                        Console.WriteLine("\nRemoved row with maximum element " + max + ":");
                        arr = DeleteRow(arr, indexMaxX);
                        Output(arr);
                    }
                    else
                        Console.WriteLine("\nThe row with the maximum element has been removed along with the minimum.");
                    break;
                case 1:
                    Console.WriteLine("\nRemoved column with minimal element " + min + ":");
                    arr = DeleteColumn(arr, indexMinY);
                    Output(arr);

                    if (indexMinY != indexMaxY)
                    {
                        if (indexMaxY != 0 && indexMaxY > indexMinY) indexMaxY--;
                        Console.WriteLine("\nRemoved column with maximum element " + max + ":");
                        arr = DeleteColumn(arr, indexMaxY);
                        Output(arr);
                    }
                    else
                        Console.WriteLine("\nThe column with the maximum element has been removed along with the minimum.");
                    break;
                default:
                    Console.WriteLine("Incorrect value!");
                    break;
            }
        }
        static int[,] DeleteRow(int[,] matrix, int row_matrix)
        {
            if (matrix == null) return null;
            int rows = matrix.GetLength(0) - 1;
            int columns = matrix.GetLength(1);

            int[,] temp = new int[rows, columns];
            for (int i = 0; i < row_matrix; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp[i, j] = matrix[i, j];
                }
            }
            for (int i = row_matrix; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp[i, j] = matrix[i + 1, j];
                }
            }

            return temp;
        }
        static int[,] DeleteColumn(int[,] matrix, int column_matrix)
        {
            if (matrix == null) return null;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1) - 1;

            int[,] temp = new int[rows, columns];
            for (int i = 0; i < column_matrix; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    temp[j, i] = matrix[j, i];
                }
            }
            for (int i = column_matrix; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    temp[j, i] = matrix[j, i + 1];
                }
            }

            return temp;
        }

        static void Output(int[,] arr)
        {
            if (arr == null)
                Console.WriteLine("No matrix.");
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}