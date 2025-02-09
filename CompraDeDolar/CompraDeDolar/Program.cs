using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CompraDeDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar();
            Console.Write("Qual a cotação do dólar? ");
            ConversorDeMoeda.CotacaoDoDolar = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            dolar.DolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dolar.ValorEmReais = ConversorDeMoeda.DolarParaReais(dolar.DolaresComprados);
            dolar.ValorEmReais = ConversorDeMoeda.CalculandoImposto(dolar.ValorEmReais);
            Console.WriteLine("Valor a ser pago em reais: " + dolar.ValorEmReais.ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
