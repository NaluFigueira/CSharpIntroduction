using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1, 1);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
