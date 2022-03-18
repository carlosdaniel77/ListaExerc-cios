using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class Exercício5
    {
        static void Main1(string[] args)
        {
            double tempoGastoNaViagem;
            double velocidadeMedia;
            double distancia;
            double litros_usados;
            Console.WriteLine("Programa de cálculo para quantidade de litros de combustível!\n\n");
            Console.WriteLine("Informe o tempo gasto na viagem: ");
            tempoGastoNaViagem = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a velocidade média: ");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = tempoGastoNaViagem * velocidadeMedia;
            litros_usados = (distancia / 12);
            
            Console.WriteLine("A distância percorrida é: {0}", distancia);
            Console.WriteLine("A quantidade de litros utilizados: {0}", litros_usados);
        }
    }
}
