using System;

class SimpleCalculator
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            try
            {
                // Get user input for operands and operation
                double num1 = GetNumberInput("Enter first number: ");
                double num2 = GetNumberInput("Enter second number: ");
                Operation operation = GetOperationInput();

                // Perform calculation based on operation
                double result = Calculate(num1, num2, operation);

                // Display the result
                Console.WriteLine("Result: {0}", result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format. Please enter valid numbers.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: {0}", e.Message);
            }

            // Ask user if they want to repeat
            repeat = AskForRepeat();
        }
    }

    static double GetNumberInput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    static Operation GetOperationInput()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: return Operation.Add;
            case 2: return Operation.Subtract;
            case 3: return Operation.Multiply;
            case 4: return Operation.Divide;
            default: throw new ArgumentException("Invalid operation choice.");
        }
    }

    static double Calculate(double num1, double num2, Operation operation)
    {
        switch (operation)
        {
            case Operation.Add: return num1 + num2;
            case Operation.Subtract: return num1 - num2;
            case Operation.Multiply: return num1 * num2;
            case Operation.Divide: return num2 == 0 ? throw new DivideByZeroException() : num1 / num2;
            default: throw new ArgumentException("Invalid operation provided.");
        }
    }

    static bool AskForRepeat()
    {
        Console.Write("Do you want to perform another calculation? (y/n): ");
        string answer = Console.ReadLine().ToLower();

        return answer == "y";
    }
}
