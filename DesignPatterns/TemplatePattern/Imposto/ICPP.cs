using System;
namespace DesignPatterns.TemplatePattern
{
    public class ICPP : TaxaMinimaMaximaTemplate
    {
        protected override bool AtingiuValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double TaxaValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double TaxaValorMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
