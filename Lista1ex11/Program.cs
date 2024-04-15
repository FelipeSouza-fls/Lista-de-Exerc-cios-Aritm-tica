using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.Write("Digite o valor x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor y: ");
            y = double.Parse(Console.ReadLine());

            result = Math.Pow(x, y);
            Console.Write("A potência é: ");
            Console.WriteLine(result);
        }
    }
}
