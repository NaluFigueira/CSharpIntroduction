using System;

namespace CaracteresETextos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversões e outros tipos numéricos");

            char aMinusculo = 'a';
            Console.WriteLine(aMinusculo);

            char aMaiusculo = (char)65;
            Console.WriteLine(aMaiusculo);

            char bMaiusculo = (char)(aMaiusculo + 1);
            Console.WriteLine(bMaiusculo);

            string letrasImpressas = "Foram impressas " + 3 + " letras: " + aMinusculo + ", " + aMaiusculo + " e " + bMaiusculo + ".";

            Console.WriteLine(letrasImpressas);

            Console.WriteLine("Execução finalizada. Aperte qualquer tecla para fechar o programa...");

            Console.ReadLine();
        }
    }
}
