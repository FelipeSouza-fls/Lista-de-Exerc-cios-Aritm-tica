using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite o valor da base do retangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do retangulo: ");
            a = int.Parse(Console.ReadLine());

            area = b * a;
            Console.Write("O valor da área do retângulo é: ");
            Console.WriteLine(area);
        }
    }
}
