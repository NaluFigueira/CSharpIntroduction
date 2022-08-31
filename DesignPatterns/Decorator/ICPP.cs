using System;
namespace DesignPatterns.Decorator
{
    public class ICPP : TaxaMinimaMaximaTemplate
    {
        public ICPP() : base()
        {

        }

        public ICPP(Imposto outroImposto) : base(outroImposto)
        {

        }

        protected override bool AtingiuValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double TaxaValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculaOutroImposto(orcamento);
        }

        protected override double TaxaValorMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
        }
    }
}
