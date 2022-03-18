using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício7
    {
        static void Main1(string[] args)
        {
            double celsius;
            double fahrenheit = 32;
            Console.WriteLine("Conversor de temperatura: Graus Celsios -> Fahrenheit!\n\n");
            Console.WriteLine("Digite a temperatura em Celsius: ");
            celsius = int.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 9/5;

            Console.WriteLine("\nA medida convertida é: {0}", celsius);

        }
    }
}
