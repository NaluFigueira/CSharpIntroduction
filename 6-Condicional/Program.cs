using System;

namespace Condicional
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Condicional - IR");

            double salario = 2800.01;

            if (salario >= 1900.0 && salario <= 2800.0)
                Console.WriteLine("A sua aliquota é de 7.5% e você pode deduzir até R$ 142,00");
            else
            {
                if (salario >= 2800.01 && salario <= 3751.0)
                    Console.WriteLine("A sua aliquota é de 15% e você pode deduzir até R$ 350,00");
                else
                {
                    if (salario >= 3751.01 && salario <= 4664.0)
                        Console.WriteLine("A sua aliquota é de 22.5% e você pode deduzir até R$ 636,00");
                    else
                        Console.WriteLine("Não há dados sobre essa faixa salarial.");
                }
            }

            Console.WriteLine("Execução finalizada. Aperte qualquer tecla para fechar o programa...");

            Console.ReadLine();
        }
    }
}
