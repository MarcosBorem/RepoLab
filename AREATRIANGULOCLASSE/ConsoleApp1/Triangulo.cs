using System;
namespace ConsoleApp1

{
    class Triangulo //NOME DA CLASSE
    {

        public double A; //ATRIBUTOS DA CLASSE
        public double B; //ATRIBUTOS DA CLASSE
        public double C; //ATRIBUTOS DA CLASSE

        public double Area() // O DOUBLE SIGNIFICA O TIPO DE DADO QUE O METODO RETORNA (SE NÃO RETORNA UTILIZA O "VOID")
        {
            double p = (A + B + C) / 2; // CORPO DO MÉTODO
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // CORPO DO MÉTODO
        }
        

    }
}
