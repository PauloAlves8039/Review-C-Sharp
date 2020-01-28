/*
 * Arquivo: classe Triangle
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades e método para calcular área de triângulo
 * Data: 28/01/2020
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace _001.Calculate.Triangle.Area
{
    class Triangle
    {
        public int A;
        public int B;
        public int C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
