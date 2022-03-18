using System;
using System.Collections.Generic;
using System.Text;

namespace Nível1
{
    class exercício3
    {
        static void Main1(string[] args)
        {
            int IdVendedor;
            int IdPeca;
            float PrecoPeca;
            float Quantidade;
            float ValorComissao;
            float PorcentagemComissao = 0.05f;

            Console.WriteLine("Programa para pagamento de comissão de peças!\n\n");
            Console.WriteLine("Digite a identificação do vendedor: ");
            IdVendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID da peça: ");
            IdPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça: ");
            PrecoPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            Quantidade = int.Parse(Console.ReadLine());

            ValorComissao = (PrecoPeca * Quantidade) * PorcentagemComissao;

            Console.WriteLine("O valor da comissão é de {0} reais.\n", ValorComissao);
        }

    }
}
