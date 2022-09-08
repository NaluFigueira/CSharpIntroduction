using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Builder.NotaFiscal;
using DesignPatterns.State;
using DesignPatterns.State.Conta;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Strategy Pattern Example 1
             */

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

            /*
             * Strategy Pattern Example 2
             */

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

            /*
             * Chain of Responsibility Pattern Example 1
             */

            //var orcamento = new Orcamento();

            //orcamento.AdicionarItem(new Item("Fogao", 250));
            //orcamento.AdicionarItem(new Item("Geladeira", 250));
            //orcamento.AdicionarItem(new Item("Microondas", 250));
            //orcamento.AdicionarItem(new Item("Batedeira", 250));
            //orcamento.AdicionarItem(new Item("LAPIS", 250));
            //orcamento.AdicionarItem(new Item("CANETA", 250));

            //var calculadorDescontos = new CalculadorDescontos(orcamento);

            //calculadorDescontos.ExibirDescontoCalculado();

            /*
             * Chain of Responsibility Pattern Example 2
             */

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

            /*
             * Template Pattern Example 1
             */

            //var orcamento = new Orcamento();

            //orcamento.AdicionarItem(new Item("Fogao", 250));
            //orcamento.AdicionarItem(new Item("Geladeira", 250));
            //orcamento.AdicionarItem(new Item("Microondas", 250));
            //orcamento.AdicionarItem(new Item("Batedeira", 250));

            //var calculadorDeImposto = new CalculadorDeImposto(orcamento, new IHIT());

            //calculadorDeImposto.ExibirCalculoImposto();

            /*
             * Template Pattern Example 2
             */

            //var contas = new Conta[3]
            // {
            //    new Conta("1", "Fulano", 2000, "0"),
            //    new Conta("2", "Beltrano", 100, "1"),
            //    new Conta("3", "Ciclano", 95, "2"),
            //};

            //Console.WriteLine("Relatorio simples");
            //var relatorioSimples = new Simples(contas);
            //relatorioSimples.ImprimirRelatorio();


            //Console.WriteLine("Relatorio complexo");
            //var relatorioComplexo = new Complexo(contas);
            //relatorioComplexo.ImprimirRelatorio();

            /*
             * Decorator Pattern Example 1
             */

            //var iss = new ISS();
            //var icms = new ICMS(iss);
            //var muitoAlto = new MuitoAlto(icms);
            //var icpp = new ICPP();
            //var ikcv = new IKCV(iss);

            //var orcamento = new Orcamento();
            //var item = new Item("item", 1000);

            //orcamento.AdicionarItem(item);

            //Console.WriteLine($"Valor do orçamento: {orcamento.Valor}");
            //Console.WriteLine("ISS:");
            //Console.WriteLine(iss.Calcula(orcamento));

            //Console.WriteLine("ICMS:");
            //Console.WriteLine(icms.Calcula(orcamento));

            //Console.WriteLine("Muito Alto:");
            //Console.WriteLine(muitoAlto.Calcula(orcamento));

            //Console.WriteLine("ICPP:");
            //Console.WriteLine(icpp.Calcula(orcamento));

            //Console.WriteLine("IKCV:");
            //Console.WriteLine(ikcv.Calcula(orcamento));

            /*
             * Decorator Pattern Example 2
             */

            //var contas = new List<Conta>();

            //var contaComSaldoMaior500Mil = new Conta("maior500");
            //contaComSaldoMaior500Mil.Saldo = 600000;

            //var contaComSaldoMenor100 = new Conta("menor100");
            //contaComSaldoMenor100.Saldo = 50;

            //var contaMesNaoCorrente = new Conta("mesNaoCorrente");
            //contaMesNaoCorrente.DataAbertura = DateTime.Now.AddMonths(1);

            //contas.Add(contaComSaldoMaior500Mil);
            //contas.Add(contaComSaldoMenor100);
            //contas.Add(contaMesNaoCorrente);

            //var filtro1 = new DataAberturaMesCorrente(new SaldoMaior500Mil());
            //var filtro2 = new DataAberturaMesCorrente(new SaldoMenor100());
            //var filtro3 = new SaldoMenor100();
            //var filtro4 = new SaldoMaior500Mil();
            //var filtro5 = new DataAberturaMesCorrente();

            //filtro1.ExibirListaFiltrada(contas);
            //filtro2.ExibirListaFiltrada(contas);
            //filtro3.ExibirListaFiltrada(contas);
            //filtro4.ExibirListaFiltrada(contas);
            //filtro5.ExibirListaFiltrada(contas);

            /*
             * State Pattern Example 1
             */

            //var orcamento = new Orcamento(100);

            //Console.WriteLine(orcamento.Valor);

            //orcamento.AplicarDescontoExtra();

            //Console.WriteLine(orcamento.Valor);

            //orcamento.Aprovar();

            //orcamento.AplicarDescontoExtra();

            //Console.WriteLine(orcamento.Valor);

            //orcamento.Finalizar();

            //orcamento.AplicarDescontoExtra();

            /*
             * State Pattern Example 2
             */

            //var conta = new Conta("Ana");

            //Console.WriteLine(conta.Saldo);

            //conta.Depositar(100);

            //Console.WriteLine(conta.Saldo);

            //conta.Sacar(200);

            //Console.WriteLine(conta.Saldo);

            //conta.Depositar(150);

            //Console.WriteLine(conta.Saldo);

            /*
             * Builder Pattern Example 1
             */

            NotaFiscal notaFiscal = new NotaFiscalBuilder()
                                    .ComRazaoSocial("Isabela e Roberto Advocacia ME")
                                    .ComCNPJ("05.596.147/0001-00")
                                    .ComDataDeAgora()
                                    .ComItem(new ItemDaNota("Honorário", 250))
                                    .ComObservacoes("--")
                                    .Constroi();
            Console.WriteLine(notaFiscal.RazaoSocial);
            Console.WriteLine(notaFiscal.CNPJ);
            Console.WriteLine(notaFiscal.DataEmissao);
            Console.WriteLine(notaFiscal.Itens.ElementAt(0).Descricao);
            Console.WriteLine(notaFiscal.ValorBruto);
            Console.WriteLine(notaFiscal.Observacoes);
        }
    }
}
