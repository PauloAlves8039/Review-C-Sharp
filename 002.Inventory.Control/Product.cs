/*
 * Arquivo: classe Product
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades e métodos para controle de produtos em um estoque
 * Data: 29/01/2020
*/

using System.Globalization;

namespace _002.Inventory.Control
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

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
