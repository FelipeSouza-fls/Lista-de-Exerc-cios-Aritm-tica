using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double cotaçao;
            double real;

            Console.Write("Digite o valor da cotação do Dolar: ");
            cotaçao = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser convertido em Reais: ");
            dolar = double.Parse(Console.ReadLine());

            real = dolar * cotaçao;
            Console.Write("O valor em Reais é: R$ ");
            Console.WriteLine(real);
        }
    }
}
