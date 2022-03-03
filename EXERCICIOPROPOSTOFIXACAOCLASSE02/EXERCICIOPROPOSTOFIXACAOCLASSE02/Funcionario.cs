using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EXERCICIOPROPOSTOFIXACAOCLASSE02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;

        }

        public void AumentarSalario(double porcetagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcetagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
