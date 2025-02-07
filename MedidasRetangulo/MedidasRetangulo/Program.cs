using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MedidasRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a largura e a altura do retangulo:");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetro = retangulo.Perimetro();
            double area = retangulo.Area();
            double diagonal = retangulo.Diagonal();

            Console.WriteLine("Perímetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
