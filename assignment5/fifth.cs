using System;

class ExceptionHandlingDemo
{
    static void Main(string[] args)
    {
        // Array with index out of bounds
        int[] arr = { 1, 2, 3 };
        try
        {
            int element = arr[3]; // IndexOutOfRangeException
            Console.WriteLine("Element: {0}", element);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index Out of Range: {0}", e.Message);
        }

        // String parsing with invalid format
        string str = "123A";
        try
        {
            int number = int.Parse(str); // FormatException
            Console.WriteLine("Number: {0}", number);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid format: {0}", e.Message);
        }

        // Collection modification during iteration
        List<string> list = new List<string>();
        list.Add("a");
        list.Add("b");
        try
        {
            foreach (string item in list)
            {
                list.Add("c"); // InvalidOperationException
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Collection modified during iteration: {0}", e.Message);
        }

        // Handle any other uncaught exceptions
        catch (Exception e)
        {
            Console.WriteLine("Unhandled Exception: {0}", e.Message);
        }
    }
}
