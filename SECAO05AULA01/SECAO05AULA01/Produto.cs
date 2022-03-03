using System.Globalization;


namespace SECAO05AULA01
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
      
        public int Quantidade { get; private set; }
       

        public Produto()//Construtor
        {
        }

        public Produto(string nome, double preco, int quantidade) //Construtor
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome //Propiedades customizadas
        { 
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
       
       
        


        /*public Produto(string nome, double preco)// SOBRECARGA
        {
            Nome = nome;
            Preco = preco;
            
        }
        */

        // Outros métodos
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
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + Quantidade
                + " Unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
