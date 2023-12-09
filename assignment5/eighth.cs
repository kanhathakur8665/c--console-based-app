using System;

class RethrowExceptionDemo
{
    static void Main(string[] args)
    {
        try
        {
            // Try to perform some action
            DoSomethingThatMightThrow();
        }
        catch (Exception e)
        {
            Console.WriteLine("Caught exception in main: {0}", e.Message);

            // Rethrow the exception (propagate it further)
            throw;
        }
    }

    static void DoSomethingThatMightThrow()
    {
        try
        {
            // Perform an operation that might throw an exception
            // In this example, we throw a custom exception
            throw new MyCustomException("This is a custom exception.");
        }
        catch (MyCustomException e)
        {
            // Handle the custom exception
            Console.WriteLine("Caught custom exception: {0}", e.Message);
        }
    }
}

public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}
