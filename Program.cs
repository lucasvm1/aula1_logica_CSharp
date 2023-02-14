using System;
using System.Globalization;

namespace Aula1
{
    class program
    {
        static void Main(string[] args)
        {
            double dolar = 5.32;

            double real;
            double conversao;

            Console.WriteLine("Quantos reais deseja doar?");
            real = Convert.ToDouble(Console.ReadLine());

            conversao = real / dolar;

            Console.WriteLine("Você terá doado: $" + conversao.ToString("N2"));


        }
    }
}