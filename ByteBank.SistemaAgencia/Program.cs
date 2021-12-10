using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
                ContaCorrente conta = new ContaCorrente(874, 1234567);

                contas.AdicionarVarios(
                    new ContaCorrente(874, 1234568),
                    new ContaCorrente(874, 1234569),
                    conta,
                    new ContaCorrente(874, 1234510),
                    new ContaCorrente(874, 1234511)
                );

                contas.EscreverListaNaTela();

                contas.Remover(conta);

                contas.EscreverListaNaTela();

                Console.WriteLine(
                    $"Acessando pelo indexador a primeira conta: {contas[0]}"
                );

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
