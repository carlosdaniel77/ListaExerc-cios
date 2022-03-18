using System;

namespace Nível1
{
    class Exercício1
    {
        static void Main1(string[] args)
        {
            int estMed;
            int qtdMin;
            int qtdMax;
            Console.WriteLine("Programa de Cálculo de um Estoque!");
            Console.WriteLine("Informe a quantidade miníma: ");
            qtdMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade máxima: ");
            qtdMax = int.Parse(Console.ReadLine());

            estMed = (qtdMin + qtdMax) / 2;
            Console.WriteLine("O estoque médio da peça é: {0}", estMed);

        }
    }
}
