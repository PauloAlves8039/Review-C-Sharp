using System;
using System.Globalization;

namespace _003.Calculate.Radius
{
    /// <summary>
    /// Classe que representa ponto de entrada e saída de dados referentes ao valor do raio
    /// <remarks>Classe utiliza método Main para execução da aplicação.</remarks>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circumference(radius);
            double bulk = Calculator.Bulk(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Bulk: " + bulk.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Value of PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
