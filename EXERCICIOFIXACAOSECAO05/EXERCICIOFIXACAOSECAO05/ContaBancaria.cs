using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EXERCICIOFIXACAOSECAO05
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get;}
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public ContaBancaria(int numero, string nome, double depositoinicial): this(numero,nome)
        {
            ValorDeposito(depositoinicial);
        }

       

        public void ValorDeposito(double deposito)
        {
            Saldo = Saldo + deposito;
            
        }

        public void ValorSaque(double saque)
        {
            double taxa = 5.00;
            Saldo = Saldo - saque - taxa;
            
        }
        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Nome + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
