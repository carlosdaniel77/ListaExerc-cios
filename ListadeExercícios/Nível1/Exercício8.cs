using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício8
    {
        static void Main1(string[] args)
        {
            double raio;
            double altura;
            double volume;
            Console.WriteLine("Programa de cálculo do volume de uma lata de óleo! \n\n");
            Console.WriteLine("Entre com o valor de raio: ");
            raio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor da altura: ");
            altura = int.Parse(Console.ReadLine());

            volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("\nO valor do volume é: {0}", volume);

        }
    }
}
