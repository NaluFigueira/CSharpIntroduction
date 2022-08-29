using System;
namespace DesignPatterns.TemplatePattern
{
    public class IKCV : TaxaMinimaMaximaTemplate
    {
        protected override bool AtingiuValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.PossuiItemComValorMaiorA(100);
        }

        protected override double TaxaValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double TaxaValorMinimo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
