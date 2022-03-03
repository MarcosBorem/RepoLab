using System;
using System.Collections.Generic;
using System.Text;

namespace EXERCICIOFIXACAOMEMBROSESTATICOS
{
    class ConversorDeMoeda
    {
        public static double Iof = 1.06;// MEMBRO
        
        public static double ValorReais(double CotacaoDolar, double QuantidadeDolar)//MÉTODO
        {
            double total = CotacaoDolar * QuantidadeDolar;
            return total * Iof;
        }
        
    }
}
