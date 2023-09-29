using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_practicals
{
    internal class Sixth
    {
        public static void SumOfTwoMatrix()
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for Array1 row: " + (i + 1) + " and column: " + (j + 1) + ": ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix 1 is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for Array2 row: " + (i + 1) + " and column: " + (j + 1) + ": ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix 2 is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i,j];
            Console.WriteLine("Sum of Matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
