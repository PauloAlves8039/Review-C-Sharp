using System;
using System.Globalization;

namespace _001.Calculate.Triangle.Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle();
            Triangle y = new Triangle();

            Console.WriteLine("Enter the measures of triangle X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measures of triangle Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("The area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("The area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

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
