using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public double CalculatePrice()
    {
        return Price * Quantity;
    }

    public double CalculatePrice(double discount)
    {
        double total = Price * Quantity;
        return total - discount;
    }
}

class Program
{
    static void Main()
    {
        List<Product> cart = new List<Product>();

        cart.Add(new Product { Name = "C# Programming", Price = 50, Quantity = 2 });
        cart.Add(new Product { Name = "Headphones", Price = 100, Quantity = 1 });
        cart.Add(new Product { Name = "T-Shirt", Price = 20, Quantity = 5 });

        double grandTotal = 0;

        Console.WriteLine("Shopping Cart Details:\n");

        foreach (Product p in cart)
        {
            double total = p.CalculatePrice(10);

            Console.WriteLine($"{p.Name} | Price: ${p.Price} | Quantity: {p.Quantity}");
            Console.WriteLine($"Total Price: ${total}\n");

            grandTotal += total;
        }

        Console.WriteLine($"Grand Total for Cart: ${grandTotal}");
    }
}