using System;
using System.Globalization;

namespace _001.Calculate.Triangle.Area
{
    /// <summary>
    /// Classe que representa ponto de entrada e saída de dados da aplicação.
    /// </summary>
    /// <remarks>Classe utiliza método Main para execução da aplicação.</remarks>
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Instâncias da classe Triangle para representar os triângulos X e Y.
            /// </summary>
            Triangle x = new Triangle();
            Triangle y = new Triangle();

            /// <summary>
            /// Entrada de dados
            /// </summary>
            Console.WriteLine("Enter the measures of triangle X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measures of triangle Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /// <value>Obtêm medida do triângulo X.</value>
            double areaX = x.Area();

            /// <value>Obtêm medida do triângulo Y.</value>
            double areaY = y.Area();

            /// <summary>
            /// Saída de dados
            /// </summary>
            Console.WriteLine("The area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("The area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            /// <summary>
            /// Verificando qual dos triângulos possui maior área
            /// </summary>
            if (areaX > areaY)
            {
                Console.WriteLine("Larger area: X");
            }
            else
            {
                Console.WriteLine("Larger area: Y");
            }
        }
    }
}
