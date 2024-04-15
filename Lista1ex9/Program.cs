using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double area;

            Console.Write("Digite o valor do diametro: ");
            diametro = double.Parse(Console.ReadLine());
            diametro = (diametro / 2);
            diametro = (diametro * diametro);

            area = (3.1415 * diametro);
            Console.Write("O valor da área é: ");
            Console.Write(area);
        }
    }
}
