using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ListaDeContaCorrente contas = new ListaDeContaCorrente();

            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
            contas.Adicionar(new ContaCorrente(874, 1234567));
        }
    }
}
