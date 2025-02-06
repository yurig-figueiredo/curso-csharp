using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaMaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else if (pessoa1.Idade < pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
            else
            {
                Console.WriteLine($"Não tem pessoa mais velha. {pessoa1.Nome} e {pessoa2.Nome} possuem a mesma idade");
            }

            Console.ReadLine();
        }
    }
}
