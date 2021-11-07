using System;

namespace ConversoesEOutrosTiposNumericos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversões e outros tipos numéricos");

            double salario = 1250.50;

            int salarioConvertido = (int)salario;

            Console.WriteLine("Meu salário atual é " + salarioConvertido + ".");

            float salarioNovo = 2250.50f;

            Console.WriteLine("Meu novo salário será " + salarioNovo + ".");

            Console.WriteLine("Execução finalizada. Aperte qualquer tecla para fechar o programa...");

            Console.ReadLine();
        }
    }
}
