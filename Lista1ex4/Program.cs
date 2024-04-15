using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite o valor da base: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            a = int.Parse(Console.ReadLine());

            area = (b * a) / 2;
            Console.Write("O valor da área é: ");
            Console.WriteLine(area);
           


        }
    }
}
