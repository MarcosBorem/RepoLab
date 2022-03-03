using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoVetor
{
    class Cadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Cadastro(string nome, string email)
        {
            Nome = nome;
            Email = email;
            
        }
        public override string ToString()
        {
            return Nome+ ", "
                +Email;
        }
    }
}
