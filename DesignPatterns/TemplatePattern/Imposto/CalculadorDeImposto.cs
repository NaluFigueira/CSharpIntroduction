using System;
namespace DesignPatterns.TemplatePattern
{
    public class CalculadorDeImposto
    {
        public Orcamento Orcamento { get; set; }
        public Imposto Imposto { get; set; }

        public CalculadorDeImposto(Orcamento orcamento, Imposto imposto)
        {
            this.Orcamento = orcamento;
            this.Imposto = imposto;
        }

        public void ExibirCalculoImposto()
        {
            var resultado = Imposto.Calcula(Orcamento);
            Console.WriteLine(resultado);
        }
    }
}
