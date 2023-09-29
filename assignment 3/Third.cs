using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_practicals
{
    internal class Third
    {
        public static void Loops()
        {
            Console.Write("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of "+num+" using for loop ->\n");
            int i;
            for(i=1; i<=10;i++)
                Console.WriteLine(num+ " x "+i+" ="+(num*i));
            i = 1;
            Console.WriteLine("\nTable of " + num + " using while loop ->\n");
            while (i <= 10) {
                Console.WriteLine(num + " x " + i + " =" + (num * i));
                i++;
            }
            i = 1;
            Console.WriteLine("\nTable of " + num + " using do-while loop ->\n");
            do
            {
                Console.WriteLine(num + " x " + i + " =" + (num * i));
                i++;
            } 
            while (i<=10);
            Console.WriteLine("\nUse of for each loop -> ");
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach(int x in arr)
                Console.Write(x + " ");
        }
    }
}
