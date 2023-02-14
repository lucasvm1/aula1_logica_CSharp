using System;

namespace Aula1
{
    class program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            double resultado = 0;
            string sinal;

            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual função deseja realizar?");

            sinal = Console.ReadLine();

            if (sinal == "+")
            {
                resultado = n1 + n2;
            } else if (sinal == "-") {
                resultado = n1 - n2;
            } else if (sinal == "*")
            {
                resultado = n1 * n2;
            } else if (sinal == "/")
            {
                resultado = n1 / n2;
            } else
            {
                Console.WriteLine("Nao reconheco esse comando!!");
            }

            Console.WriteLine(resultado);

            

                
        }
    }
}