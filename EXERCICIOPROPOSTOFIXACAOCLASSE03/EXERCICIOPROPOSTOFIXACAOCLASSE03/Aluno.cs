using System;
using System.Collections.Generic;
using System.Text;

namespace EXERCICIOPROPOSTOFIXACAOCLASSE03
{
    class Aluno
    {
        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal() 
        {
            return PrimeiroTrimestre + SegundoTrimestre + +TerceiroTrimestre;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
                        
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }
    }
}
