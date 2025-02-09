using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Circunferencia
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunf = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circunf.ToString("F2"), CultureInfo.InvariantCulture);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de pi: " + Calculadora.Pi.ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }

        
    }
}
