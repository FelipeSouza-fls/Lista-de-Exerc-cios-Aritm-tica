using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            double media;

            Console.Write("Digite o primeiro valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            val2 = double.Parse(Console.ReadLine());

            media = Math.Sqrt(val1 * val2);
            Console.Write("O valor da média geométrica é: ");
            Console.WriteLine(media);

        }
    }
}
