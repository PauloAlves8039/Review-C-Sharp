using System;
using System.Globalization;

namespace _004.Dollar.Exchange
{
    /// <summary>
    /// Classe que representa ponto de entrada e saída de dados referentes a conversão de moeda
    /// <remarks>Classe utiliza método Main para execução da aplicação.</remarks>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the dollar quote? ");
            double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars will you buy? ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.DollarToReal(amount, quotation);

            Console.WriteLine("Amount to be paid in real = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
