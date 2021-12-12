using System;
using System.Collections.Generic;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                List<ContaCorrente> contas = new List<ContaCorrente>();
                ContaCorrente conta = new ContaCorrente(874, 1234567);

                contas.AdicionarVarios(
                    new ContaCorrente(876, 1234569),
                    new ContaCorrente(875, 1234568),
                    conta,
                    new ContaCorrente(879, 1234566),
                    new ContaCorrente(878, 1234565)
                );

                contas.EscreverListaNaTela();

                contas.Remove(conta);

                contas.EscreverListaNaTela();

                Console.WriteLine(
                    $"Acessando pelo indexador a primeira conta: {contas[0]}"
                );


                contas.Sort();

                Console.WriteLine("Depois de ordenar pelo número da conta:");

                contas.EscreverListaNaTela();

                contas.Sort(new ComparadorContaCorrentePorAgencia());

                Console.WriteLine("Depois de ordenar pelo número da agência:");

                contas.EscreverListaNaTela();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
