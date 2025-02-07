using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AumentoSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public override string ToString()
        {
            double aux = SalarioLiquido();
            return Nome + ", $" + aux.ToString("F2", CultureInfo.InvariantCulture);
        }
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto; 
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = ((porcentagem / 100) * SalarioBruto) + SalarioBruto;
        }
    }
}
