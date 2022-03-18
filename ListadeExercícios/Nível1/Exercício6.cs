using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício6
    {
        static void Main1(string[] args)
        {
            float celsius;
            float fahrenheit;
            Console.WriteLine("Conversor de temperatura: Graus Celsios -> Fahrenheit!\n\n");
            Console.WriteLine("Digite a temperatura em Celsius: ");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;
            
            Console.WriteLine("\nA medida convertida é: {0}", fahrenheit);
        }
    }
}
