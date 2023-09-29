using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_practicals
{
    internal class Fifth
    {
        public static void ReadWriteArray()
        {
            int[,] arr = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for row: " + (i + 1) + " and column: " + (j + 1)+": ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
