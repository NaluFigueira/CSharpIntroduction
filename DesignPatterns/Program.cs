using System;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy Pattern Example 1

            var iss = new ISS();
            var icms = new ICMS();
            var iccc = new ICCC();

            var orcamento = new Orcamento(5000);

            var calculadorDeImpostoISS = new CalculadorDeImposto(orcamento, iss);
            var calculadorDeImpostoICMS = new CalculadorDeImposto(orcamento, icms);
            var calculadorDeImpostoICCC = new CalculadorDeImposto(orcamento, iccc);

            Console.WriteLine($"Valor do orçamento: {orcamento.Valor}");
            Console.WriteLine("ISS:");
            calculadorDeImpostoISS.ExibirCalculoImposto();

            Console.WriteLine("ICMS:");
            calculadorDeImpostoICMS.ExibirCalculoImposto();;

            Console.WriteLine("ICCC:");
            calculadorDeImpostoICCC.ExibirCalculoImposto();

        }
    }
}
