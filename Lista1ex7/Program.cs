using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double conversao;

            Console.Write("Digite o valor da distância em milha maritma: ");
            m = double.Parse(Console.ReadLine());

            conversao = (m + 1852)/ 1000;
            Console.Write("0 valor da distância em quilômetros é: ");
            Console.WriteLine(conversao);
        }
    }
}
