using System;

namespace _001.Calculate.Triangle.Area
{

    /// <summary>
    /// Classe responsável por conter lógica para calcular área de triângulo.
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// Propriedades que representam as medidas do lado do triângulo.
        /// </summary>
        public double A;
        public double B;
        public double C;

        /// <summary>
        /// Método tem como objetivo calcular área de triângulo.
        /// </summary>
        /// <returns>Retorna a raiz quadrada com as medidas dos lados do triângulo</returns>
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
