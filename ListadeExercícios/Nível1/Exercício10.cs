using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício10
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            bool igual = false;
            bool naoIgual = false;
            bool maior = false;
            bool menor = false;
            bool maiorIgual = false;
            bool menorIgual = false;
            Console.WriteLine("Mostrador de relacionamentos!\n\n");
            Console.WriteLine("Digite o primeiro numero: ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero == segundoNumero) igual = true;
            if (primeiroNumero != segundoNumero) naoIgual = true;
            if (primeiroNumero > segundoNumero) maior = true;
            if (primeiroNumero < segundoNumero) menor = true;
            if (primeiroNumero >= segundoNumero) maiorIgual = true;
            if (primeiroNumero <= segundoNumero) menorIgual = true;

            Console.WriteLine("Igual: {0}", igual);
            Console.WriteLine("Não igual: {0}", naoIgual);
            Console.WriteLine("Maior: {0}", maior);
            Console.WriteLine("Menor: {0}", menor);
            Console.WriteLine("Maior ou igual: {0}", maiorIgual);
            Console.WriteLine("Menor ou igual: {0}", menorIgual);
        }
    }
}
