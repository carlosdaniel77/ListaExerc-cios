using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício9
    {
        static void Main1(string[] args)
        {
            double dias_no_ano = 365;
            double dias_no_mes = 30;
            double dias;
            double meses;
            double anos;
            Console.WriteLine("Programa de cálculo da idade de uma pessoa!\n\n");
            Console.WriteLine("Informe a sua idade: ");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Meses: ");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Dias: ");
            meses = int.Parse(Console.ReadLine());

            dias = (anos * dias_no_ano) + (meses * dias_no_mes);

            Console.WriteLine("A sua idade em dias é: {0}", dias);

        }
    }
}
