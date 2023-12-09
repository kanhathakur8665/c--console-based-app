using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        try
        {
            // Attempt to access an out-of-bounds element
            int index = 5; // This index is out of bounds
            int element = numbers[index];

            Console.WriteLine($"Element at index {index}: {element}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.Error.WriteLine(e.Message);
            Console.Error.WriteLine("Index was outside the bounds of the array.");
        }
        finally
        {
            Console.WriteLine("Program complete.");
        }
    }
}
