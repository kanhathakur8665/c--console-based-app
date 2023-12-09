using System;

class SafeDivision
{
    static void Main(string[] args)
    {
        bool success = false;
        do
        {
            try
            {
                // Get user input for both numbers
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                // Check if divisor is not zero
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }

                // Divide the numbers
                double result = num1 / num2;

                // Display the result
                Console.WriteLine("The quotient is: {0}", result);

                success = true; // Division successful
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format. Please enter valid numbers.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // Catch any other exceptions
            {
                Console.WriteLine("An unexpected error occurred.");
            }
        } while (!success); // Continue prompting if division was not successful
    }
}
