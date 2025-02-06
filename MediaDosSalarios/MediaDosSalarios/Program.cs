using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaDosSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Digite os dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   

            Console.Clear();

            double mediaDosSalarios = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine($"Média dos salários: {mediaDosSalarios:F2}");
            Console.ReadLine();
        }
    }
}
