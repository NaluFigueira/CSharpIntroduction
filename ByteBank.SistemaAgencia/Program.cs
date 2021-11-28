using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            string argumentos = url.Substring(7);

            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
