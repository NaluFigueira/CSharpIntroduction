using System;
namespace DesignPatterns.Decorator
{
    public class IKCV : TaxaMinimaMaximaTemplate
    {
        public IKCV() : base()
        {

        }

        public IKCV(Imposto outroImposto) : base(outroImposto)
        {

        }

        protected override bool AtingiuValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.PossuiItemComValorMaiorA(100);
        }

        protected override double TaxaValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculaOutroImposto(orcamento);
        }

        protected override double TaxaValorMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
        }
    }
}
