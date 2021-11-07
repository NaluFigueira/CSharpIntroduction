using System;

namespace Fatorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;

                Console.WriteLine("O fatorial de " + n + " é " + fatorial);
            }
        }
    }
}
