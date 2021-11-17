using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Criando conta corrente...");
                ContaCorrente primeiraContaCorrente = new ContaCorrente(-1, 82507);
                primeiraContaCorrente.Saldo = 200;
                Console.WriteLine("O saldo atual é R$ " + primeiraContaCorrente.Saldo + ",00.");

                Console.WriteLine("Sacando R$ 100,00...");
                primeiraContaCorrente.Sacar(100);
                Console.WriteLine("O saldo atual é R$ " + primeiraContaCorrente.Saldo + ",00.");

                Console.WriteLine("Criando outra conta corrente...");
                ContaCorrente segundaContaCorrente = new ContaCorrente(868, 83001);
                segundaContaCorrente.Saldo = 50;
                Console.WriteLine("O saldo atual da primeira conta é R$ " + primeiraContaCorrente.Saldo + ",00.");
                Console.WriteLine("O saldo atual da segunda conta é R$ " + segundaContaCorrente.Saldo + ",00.");

                Console.WriteLine("Adicionando titular na primeira conta...");
                primeiraContaCorrente.Titular = new Cliente();
                primeiraContaCorrente.Titular.Nome = "Camila";
                Console.WriteLine("A titular da primeira conta é a " + primeiraContaCorrente.Titular.Nome + ".");

                Console.WriteLine("O total de classes criadas é " + ContaCorrente.TotalDeContasCriadas + ".");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
