using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int area;

            Console.Write("Digite o valor da diagonal: ");
            d = int.Parse(Console.ReadLine());

            area = (d * d) / 2;
            Console.Write("O valor da área é: ");
            Console.WriteLine(area);

        }
    }
}
