using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício2
    {
        static void Main1(string[] args)
        {
            double cotacao_dolar;
            double valor_dolar;
            double valor_real;
            Console.WriteLine("Conversor de dólares em reais!\n\n");
            Console.WriteLine("Digite a cotação do dólar: ");
            cotacao_dolar = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólar: ");
            valor_dolar = int.Parse(Console.ReadLine());

            valor_real = cotacao_dolar * valor_dolar;
            Console.WriteLine("O Valor em reais é: {0}", valor_real);

        }
    }
}
