using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string url = "cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

                ExtratorValorDeArgumentosURL extrator =
                    new ExtratorValorDeArgumentosURL(url);

                Console.WriteLine(extrator.GetValor("valor"));

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
