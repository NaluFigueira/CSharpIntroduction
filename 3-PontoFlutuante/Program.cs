using System;

namespace PontoFlutuante
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ponto Flutuante");

            double salario = 1250.70;

            Console.WriteLine("Meu salário atual é " + salario + ".");

            double salarioNovo = 3255.0 / 2;

            Console.WriteLine("Meu novo salário será " + salarioNovo + ".");

            Console.WriteLine("Execução finalizada. Aperte qualquer tecla para fechar o programa...");

            Console.ReadLine();
        }
    }
}
