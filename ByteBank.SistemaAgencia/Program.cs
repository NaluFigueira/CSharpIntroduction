using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 39876);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
