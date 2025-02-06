using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("This is my first code in C#");
            int alturaDosBlocos = 4;

            for(int i = 0; i < alturaDosBlocos; i++)
            {
                for(int j = -1; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
