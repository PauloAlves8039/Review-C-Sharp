using System;
using System.Globalization;

namespace _002.Inventory.Control
{
    /// <summary>
    /// Classe que representa ponto de entrada e saída de dados dos produtos
    /// </summary>
    /// <remarks>Classe utiliza método Main para execução da aplicação.</remarks>
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Instância da classe Product para representar a entidade produto.
            /// </summary>
            Product p = new Product();

            /// <summary>
            /// Entrada de dados.
            /// </summary>
            Console.WriteLine("Enter product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");
            p.Quantity = int.Parse(Console.ReadLine());

            /// <summary>
            /// Informa a saída dos dados atualizados do estoque.
            /// </summary>
            Console.WriteLine();
            Console.WriteLine("Product Data: " + p);

            /// <summary>
            /// Entrada de dados com chamada do método AddProducts()
            /// </summary>
            /// <param name="qty">Parâmetro para representar a propriedade Quantity.</param>
            Console.WriteLine();
            Console.Write("Enter the number of products to be added to the stock: ");
            int qty = int.Parse(Console.ReadLine());
            p.AddProducts(qty);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);

            /// <summary>
            /// Entrada de dados com chamada do método RemoveProducts()
            /// </summary>
            Console.WriteLine();
            Console.Write("Enter the number of products to be removed from stock: ");
            qty = int.Parse(Console.ReadLine());
            p.RemoveProducts(qty);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);
        }
    }
}
