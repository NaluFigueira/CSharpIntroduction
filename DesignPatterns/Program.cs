using System;
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Investimento;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy Pattern Example 1

            //var iss = new ISS();
            //var icms = new ICMS();
            //var iccc = new ICCC();

            //var orcamento = new Orcamento(5000);

            //var calculadorDeImpostoISS = new CalculadorDeImposto(orcamento, iss);
            //var calculadorDeImpostoICMS = new CalculadorDeImposto(orcamento, icms);
            //var calculadorDeImpostoICCC = new CalculadorDeImposto(orcamento, iccc);

            //Console.WriteLine($"Valor do orçamento: {orcamento.Valor}");
            //Console.WriteLine("ISS:");
            //calculadorDeImpostoISS.ExibirCalculoImposto();

            //Console.WriteLine("ICMS:");
            //calculadorDeImpostoICMS.ExibirCalculoImposto();;

            //Console.WriteLine("ICCC:");
            //calculadorDeImpostoICCC.ExibirCalculoImposto();

            // Strategy Pattern Example 2

            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            var conta = new Conta();

            conta.Depositar(1000);

            var realizadorDeInvestimentosConservador  = new RealizadorDeInvestimentos(conta, conservador);
            var realizadorDeInvestimentosModerado  = new RealizadorDeInvestimentos(conta, moderado);
            var realizadorDeInvestimentosArrojado = new RealizadorDeInvestimentos(conta, arrojado);

            Console.WriteLine($"Valor do saldo: {conta.Saldo}");
            Console.WriteLine("Conservador:");
            realizadorDeInvestimentosConservador.Aplicar();

            Console.WriteLine("Moderado:");
            realizadorDeInvestimentosModerado.Aplicar();

            Console.WriteLine("Arrojado:");
            realizadorDeInvestimentosArrojado.Aplicar();

        }
    }
}
