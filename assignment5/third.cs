using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = Console.ReadLine(); // Get user input

        try
        {
            int userNumber = int.Parse(userInput); // Convert string to integer
            Console.WriteLine($"Successfully converted '{userInput}' to {userNumber}");
        }
        catch (FormatException e)
        {
            Console.Error.WriteLine("Error: Invalid input format.");
            Console.Error.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Program complete.");
        }
    }
}
