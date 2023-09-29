using System;

namespace C__lab_practicals
{
    internal class Second
    {
        public static void ControlStatement()
        {
            Console.WriteLine("# Use of if-else in Control statement\n");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.WriteLine("\n# Use of Switch in Control statement\n");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@"######################## MENU ##########################
1. Addition 2. Subtraction 3. Multiplication 4. Division
########################################################" + "\n");
            Console.Write("Choose as you like: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("The sum of two numbers is: " + (num1 + num2));
                    break;
                case 2:
                    Console.Write("The difference of two numbers is: " + (num1 - num2));
                    break;
                case 3:
                    Console.Write("The multiplication of two numbers is: " + (num1 * num2));
                    break;
                case 4:
                    Console.Write("The division of two numbers is: " + (num1 / num2));
                    break;
                default:
                    Console.Write("Wrong menu choice");
                    break;
            }
        }
        static void Main()
        {
            //ControlStatement();
            //First.HelloWorld();
            //Third.Loops();
            //Fifth.ReadWriteArray();
            Sixth.SumOfTwoMatrix();
            Console.Read();
        }
    }
}
