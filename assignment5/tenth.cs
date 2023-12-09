using System;

class ShoppingCart
{
    const int MAX_PRICE = 10000; // Define maximum price

    static void Main(string[] args)
    {
        int[] cart = new int[10]; // Array to store item prices
        int itemCount = 0; // Number of items in the cart
        bool continueAdding = true;

        while (continueAdding)
        {
            try
            {
                // Prompt user for price
                Console.Write("Enter price of item: ");
                string priceInput = Console.ReadLine();

                // Check if price is negative
                int price = int.Parse(priceInput);
                if (price < 0)
                {
                    throw new NegativePriceException("Price cannot be negative.");
                }

                // Check if price exceeds maximum
                if (price > MAX_PRICE)
                {
                    throw new PriceTooHighException("Price exceeds maximum limit of " + MAX_PRICE);
                }

                // Add price to cart and update count
                cart[itemCount] = price;
                itemCount++;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
            }
            catch (NegativePriceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PriceTooHighException e)
            {
                Console.WriteLine(e.Message);
            }

            // Ask user if they want to add more items
            Console.Write("Add another item? (y/n): ");
            string answer = Console.ReadLine().ToLower();
            continueAdding = answer == "y";
        }

        // Calculate and display total price
        int totalPrice = 0;
        for (int i = 0; i < itemCount; i++)
        {
            totalPrice += cart[i];
        }

        Console.WriteLine("Total price: $" + totalPrice);
    }
}

public class NegativePriceException : Exception
{
    public NegativePriceException(string message) : base(message)
    {
    }
}

public class PriceTooHighException : Exception
{
    public PriceTooHighException(string message) : base(message)
    {
    }
}
