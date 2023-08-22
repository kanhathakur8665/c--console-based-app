using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecondSmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 8, 3, 7, 2 };

            

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            Console.WriteLine($"The second smallest element is: {secondSmallest}");
            Console.ReadLine();
        }
    }
}

