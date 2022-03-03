using System.Globalization;


namespace SEGUNDOPROBLEMAEXEMPLOCLASSE
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() 
        {
            double totalemestoque = (Quantidade * Preco);
            return totalemestoque;
            
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + Quantidade
                + " Unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
