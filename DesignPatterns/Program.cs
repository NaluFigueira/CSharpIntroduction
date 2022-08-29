using System;
using System.Collections;
using DesignPatterns.TemplatePattern;
using DesignPatterns.TemplatePattern.Relatorio;

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

            //var conservador = new Conservador();
            //var moderado = new Moderado();
            //var arrojado = new Arrojado();

            //var conta = new Conta();

            //conta.Depositar(1000);

            //var realizadorDeInvestimentosConservador  = new RealizadorDeInvestimentos(conta, conservador);
            //var realizadorDeInvestimentosModerado  = new RealizadorDeInvestimentos(conta, moderado);
            //var realizadorDeInvestimentosArrojado = new RealizadorDeInvestimentos(conta, arrojado);

            //Console.WriteLine($"Valor do saldo: {conta.Saldo}");
            //Console.WriteLine("Conservador:");
            //realizadorDeInvestimentosConservador.Aplicar();

            //Console.WriteLine("Moderado:");
            //realizadorDeInvestimentosModerado.Aplicar();

            //Console.WriteLine("Arrojado:");
            //realizadorDeInvestimentosArrojado.Aplicar();

            // Chain of responsibility Example 1

            //var orcamento = new Orcamento();

            //orcamento.AdicionarItem(new Item("Fogao", 250));
            //orcamento.AdicionarItem(new Item("Geladeira", 250));
            //orcamento.AdicionarItem(new Item("Microondas", 250));
            //orcamento.AdicionarItem(new Item("Batedeira", 250));
            //orcamento.AdicionarItem(new Item("LAPIS", 250));
            //orcamento.AdicionarItem(new Item("CANETA", 250));

            //var calculadorDescontos = new CalculadorDescontos(orcamento);

            //calculadorDescontos.ExibirDescontoCalculado();

            // Chain of responsibility Example 2

            //var conta = new Conta("Teste", 1000);
            //var requisicao1 = new Requisicao(Formato.PORCENTO);
            //var requisicao2 = new Requisicao(Formato.XML);
            //var requisicao3 = new Requisicao(Formato.CSV);

            //var enfileiradorRequisicoes = new EnfileiradorRequisicoes(requisicao1, conta);

            //enfileiradorRequisicoes.ProcessarRequisicao();

            //enfileiradorRequisicoes.Requisicao = requisicao2;

            //enfileiradorRequisicoes.ProcessarRequisicao();

            //enfileiradorRequisicoes.Requisicao = requisicao3;

            //enfileiradorRequisicoes.ProcessarRequisicao();

            // Template Pattern Example 1

            //var orcamento = new Orcamento();

            //orcamento.AdicionarItem(new Item("Fogao", 250));
            //orcamento.AdicionarItem(new Item("Geladeira", 250));
            //orcamento.AdicionarItem(new Item("Microondas", 250));
            //orcamento.AdicionarItem(new Item("Batedeira", 250));

            //var calculadorDeImposto = new CalculadorDeImposto(orcamento, new IHIT());

            //calculadorDeImposto.ExibirCalculoImposto();

            // Template Pattern Example 2

            var contas = new Conta[3]
             {
                new Conta("1", "Fulano", 2000, "0"),
                new Conta("2", "Beltrano", 100, "1"),
                new Conta("3", "Ciclano", 95, "2"),
            };

            Console.WriteLine("Relatorio simples");
            var relatorioSimples = new Simples(contas);
            relatorioSimples.ImprimirRelatorio();


            Console.WriteLine("Relatorio complexo");
            var relatorioComplexo = new Complexo(contas);
            relatorioComplexo.ImprimirRelatorio();
        }
    }
}
