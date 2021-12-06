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
                string argumentos = "moedaOrigem=real&moedaDestino=dolar&valor=1500";
                string url = "https://www.bytebank.com.br/cambio?"+argumentos;

                ExtratorValorDeArgumentosURL extrator =
                    new ExtratorValorDeArgumentosURL(url);

                Console.WriteLine("Moeda de origem: " + extrator.GetValor("moedaOrigem"));
                Console.WriteLine("Moeda de destino: " + extrator.GetValor("moedaDestino"));
                Console.WriteLine("Valor: " + extrator.GetValor("valor"));

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
