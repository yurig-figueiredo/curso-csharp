using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Digite as medidas do triângulo X:");
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triângulo Y:");
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetroX = (x1 + x2 + x3) / 2;
            double perimetroY = (y1 + y2 + y3) / 2;

            double areaX = Math.Sqrt(perimetroX * (perimetroX - x1) * (perimetroX - x2) * (perimetroX - x3));
            double areaY = Math.Sqrt(perimetroY * (perimetroY - y1) * (perimetroY - y2) * (perimetroY - y3));

            string maior;

            if (areaX > areaY)
            {
                maior = "Triângulo X";
            }
            else
            {
                maior = "Triângulo Y";
            }
            Console.WriteLine($"Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"O triângulo de maior área é o {maior}");
            Console.ReadLine();
        }
    }
}
