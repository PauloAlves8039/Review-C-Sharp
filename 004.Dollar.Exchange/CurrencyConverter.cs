namespace _004.Dollar.Exchange
{
    /// <summary>
    /// Classe responsável por calculo a conversão de moeda usando membros estáticos
    /// </summary>
    class CurrencyConverter
    {
        /// <value>Representa o valor de Ftt - Financial transaction tax (Imposto sobre operações financeiras)</value>
        public static double Ftt = 6.0;

        /// <summary>
        /// Método para convenção de moeda em dólar para real
        /// </summary>
        /// <param name="amount">Informa a quantia recebida</param>
        /// <param name="quotation">Informa o valor da cotação</param>
        /// <returns>Retorna o total da quantia somada com a cotação multiplicada pelo IOF dividido por 100
        /// </returns>
        public static double DollarToReal(double amount, double quotation) {
            double total = amount * quotation;
            return total + total * Ftt / 100.0;
        }
    }
}
