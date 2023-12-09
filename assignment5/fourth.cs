using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("User must be at least 18 years old.");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            ValidateAge(userAge);
        }
        catch (InvalidAgeException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid input format. Please enter a number.");
        }
        finally
        {
            Console.WriteLine("Program complete.");
        }
    }
}
