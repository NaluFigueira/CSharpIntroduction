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
                ListaDeContaCorrente contas = new ListaDeContaCorrente();
                ContaCorrente conta = new ContaCorrente(874, 1234567);

                contas.Adicionar(new ContaCorrente(874, 1234568));
                contas.Adicionar(new ContaCorrente(874, 1234569));
                contas.Adicionar(conta);
                contas.Adicionar(new ContaCorrente(874, 1234510));
                contas.Adicionar(new ContaCorrente(874, 1234511));

                contas.EscreverListaNaTela();

                contas.Remover(conta);

                contas.EscreverListaNaTela();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
