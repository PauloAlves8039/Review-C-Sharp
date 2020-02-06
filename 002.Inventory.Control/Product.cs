using System.Globalization;

namespace _002.Inventory.Control
{
    /// <summary>
    /// Classe responsável por conter propriedades e métodos para controle de produtos em um estoque.
    /// </summary>
    class Product
    {
        /// <value>Representa o nome do produto.</value>
        public string Name;

        /// <value>Atribui um preço ao produto.</value>
        public double Price;

        /// <value>Informa a quantidade do produto.</value>
        public int Quantity;


        /// <summary>
        /// Método para calcular o valor total dos produtos no estoque.
        /// </summary>
        /// <returns>Retorna a multiplicação do preço X quantidade dos produtos.</returns>
        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        /// <summary>
        /// Método para adicionar produto no estoque.
        /// </summary>
        /// <param name="quantity">Parâmetro inteiro para adição dos produtos.</param>
        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        /// <summary>
        /// Método para remover produto no estoque.
        /// </summary>
        /// <param name="quantity">Parâmetro inteiro para remoção dos produtos.</param>
        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        /// <summary>
        /// Sobrescrita do método ToString para saída de dados do Produtos.
        /// </summary>
        /// <returns>Retorna o resultado atual dos produtos no estoque através de suas propriedades e o método TotalValueStock().</returns>
        public override string ToString()
        {
            return Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " units, Total: $ "
                + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
