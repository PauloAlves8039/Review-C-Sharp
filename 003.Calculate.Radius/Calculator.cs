namespace _003.Calculate.Radius
{
    /// <summary>
    /// Classe responsável por calcular valor do raio utilizando membros estáticos
    /// </summary>
    class Calculator
    {
        /// <value>Representa o valor PI.</value>
        public static double Pi = 3.14;

        /// <summary>
        /// Método para calcular valor da circunferência
        /// </summary>
        /// <param name="r">Recebe o valor do raio</param>
        /// <returns>Retorna o valor 2.0 multiplicado pelo valor de Pi e pelo valor do raio</returns>
        public static double Circumference(double r) {
            return 2.0 * Pi * r;
        }

        /// <summary>
        /// Métoddo para calcular volume
        /// </summary>
        /// <param name="r">Recebe o valor do raio</param>
        /// <returns>Retorna quatro terços de Pi multiplicando o valor do raio ao cubo</returns>
        public static double Bulk(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
