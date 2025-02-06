using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            double valorNoEstoque;
            int quantidade;

            Console.WriteLine("Digite os dados do produto");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            valorNoEstoque = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(quantidade);
            valorNoEstoque = produto.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quantidade);
            valorNoEstoque = produto.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados: " + produto);
            Console.ReadLine();
        }
    }
}
