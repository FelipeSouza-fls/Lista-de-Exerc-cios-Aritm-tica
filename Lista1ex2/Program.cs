using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int area;

            Console.Write("Digite o valor da aresta: ");
            a = int.Parse(Console.ReadLine());

            area = a * a;
            Console.Write("O valor da área é:");
            Console.WriteLine(area);
        }
    }
}
