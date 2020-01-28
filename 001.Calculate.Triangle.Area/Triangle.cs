/*
 * Arquivo: classe Triangle
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades e método para calcular área de triângulo
 * Data: 28/01/2020
*/

using System;

namespace _001.Calculate.Triangle.Area
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
