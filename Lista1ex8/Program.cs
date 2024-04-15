using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cels;
            double temp;

            Console.Write("Digite o valor em grau celsius é: ");
            cels = Double.Parse(Console.ReadLine());

            temp = (cels * 1.8) + 32;
            Console.Write("O valor em grau Fahrenheit é: ");
            Console.WriteLine(temp);
        }
    }
}
