using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 1234567),
                new ContaCorrente(874, 1234567),
                new ContaCorrente(874, 1234567),
                new ContaCorrente(874, 1234567),
            };

            for(int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice + 1}: {contaAtual}");
            }
        }
    }
}
