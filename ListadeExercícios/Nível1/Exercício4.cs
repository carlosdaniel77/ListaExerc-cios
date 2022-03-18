using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício4
    {
        static void Main1(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            float xb;
            float xc;
            float xd;
            float mb;
            float mc;
            float md;
            Console.WriteLine("Programa de números inteiros!\n\n");
            Console.WriteLine("Digite a primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceiro número: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            d = int.Parse(Console.ReadLine());

            xb = a * b;
            xc = a * c;
            xd = a * c;
            mb = a + c;
            mc = a + c;
            md = a + d;
            Console.WriteLine("O resultado é: {0}", xb, mb);
            Console.WriteLine("O resultado é: {0}", xc, mc);
            Console.WriteLine("O resultado é: {0}", xd, md);

        }
    }
}
