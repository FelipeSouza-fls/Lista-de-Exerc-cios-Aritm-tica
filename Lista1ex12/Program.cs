using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            double val3;
            double val4;
            double val5;
            double pago;
            double result;

            Console.Write("Vlor do 1º produto: ");
            val1 = double.Parse(Console.ReadLine());

            Console.Write("Vlor do 2º produto: ");
            val2 = double.Parse(Console.ReadLine());

            Console.Write("Vlor do 3º produto: ");
            val3 = double.Parse(Console.ReadLine());

            Console.Write("Vlor do 4º produto: ");
            val4 = double.Parse(Console.ReadLine());

            Console.Write("Vlor do 5º produto: ");
            val5 = double.Parse(Console.ReadLine());

            Console.Write("Vlor pago: ");
            pago = double.Parse(Console.ReadLine());

            result = pago - (val1 + val2 + val3 + val4 + val5);
            Console.Write("O troco é: ");
            Console.WriteLine(result);
        }
    }
}
