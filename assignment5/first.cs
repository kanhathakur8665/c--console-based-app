using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator; // Intentional division by zero
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.Error.WriteLine("Error: Division by zero is not allowed.");
            Console.Error.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Program complete.");
        }
    }
}