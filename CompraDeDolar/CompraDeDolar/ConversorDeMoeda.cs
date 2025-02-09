using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraDeDolar
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDoDolar;
        public static double DolarParaReais(double dolaresComprados)
        {
            return CotacaoDoDolar * dolaresComprados;
        }

        public static double CalculandoImposto(double reais)
        {
            double iof = (reais * 0.06);
            return iof + reais;
        }
    }
}
