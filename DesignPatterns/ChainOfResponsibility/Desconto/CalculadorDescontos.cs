using System;
namespace DesignPatterns.ChainOfResponsibility
{
    public class CalculadorDescontos
    {
        public double ValorDescontado { get; set; }

        public CalculadorDescontos(Orcamento orcamento)
        {
            var desconto1 = new DescontoParaMais5Itens();
            var desconto2 = new DescontoParaValorMaior500();
            var desconto3 = new DescontoParaVendaCasada();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;
            desconto3.Proximo = new SemDesconto();

            ValorDescontado = desconto1.Calcula(orcamento);
        }

        public void ExibirDescontoCalculado()
        {
            Console.WriteLine(ValorDescontado);
        }
    }
}
