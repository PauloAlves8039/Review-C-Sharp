using System;
using System.Globalization;

namespace _002.Inventory.Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Enter product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Product Data: " + p);

            Console.WriteLine();
            Console.Write("Enter the number of products to be added to the stock: ");
            int qty = int.Parse(Console.ReadLine());
            p.AddProducts(qty);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);

            Console.WriteLine();
            Console.Write("Enter the number of products to be removed from stock: ");
            qty = int.Parse(Console.ReadLine());
            p.RemoveProducts(qty);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);
        }
    }
}
