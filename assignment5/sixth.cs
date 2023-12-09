using System;

class NestedTryCatchDemo
{
    static void Main(string[] args)
    {
        // Outer try block
        try
        {
            // Inner try block
            try
            {
                // Throw an exception
                throw new Exception("Inner exception message");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Inner catch block: Format exception caught");
            }
        }
        catch (Exception e)
        {
            // Catch the inner exception in the outer block
            Console.WriteLine("Outer catch block: Exception caught: {0}", e.Message);
        }
    }
}
