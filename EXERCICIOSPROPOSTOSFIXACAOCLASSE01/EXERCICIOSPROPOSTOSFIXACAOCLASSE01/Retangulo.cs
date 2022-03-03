using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace EXERCICIOSPROPOSTOSFIXACAOCLASSE01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area;
            area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {

            double perimetro = (Largura + Altura) * 2;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal1, diagonal2;

            diagonal1 = (Largura * Largura) + (Altura * Altura);
            diagonal2 = Math.Sqrt(diagonal1);
            return diagonal2;

        }

        public override string ToString()
        {
            return "Área = " +Area().ToString("F2",CultureInfo.InvariantCulture) 
                + "\n" + "Perimetro = " +Perimetro().ToString("F2",CultureInfo.InvariantCulture)
                + "\n" + "Diagonal = "+Diagonal().ToString("F2",CultureInfo.InvariantCulture);
        }

    }

}
