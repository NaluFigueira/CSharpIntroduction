using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Criou conta corrente.");
            ContaCorrente primeiraContaCorrente = new ContaCorrente();

            primeiraContaCorrente.saldo = 200;

            Console.WriteLine("O saldo é R$ " + primeiraContaCorrente.saldo + ",00.");

            primeiraContaCorrente.saldo += 100;

            Console.WriteLine("Crédito de R$ 100, 00.");
            Console.WriteLine("O saldo é R$ " + primeiraContaCorrente.saldo + ",00.");

            Console.WriteLine("Criou conta corrente.");
            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.saldo = 50;

            Console.WriteLine("O saldo da primeira conta é R$ " + primeiraContaCorrente.saldo + ",00.");
            Console.WriteLine("O saldo da segunda conta é R$ " + segundaContaCorrente.saldo + ",00.");

            Console.WriteLine("Adicionando titular a primeira conta.");

            primeiraContaCorrente.titular = new Cliente();
            primeiraContaCorrente.titular.nome = "Camila";

            Console.WriteLine("A titular da primeira conta é a " + primeiraContaCorrente.titular.nome);
        }
    }
}
