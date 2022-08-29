using System;
namespace DesignPatterns.TemplatePattern
{
    public class IHIT : TaxaMinimaMaximaTemplate
    {
        protected override bool AtingiuValorMaximo(Orcamento orcamento)
        {
            return orcamento.PossuiItensComMesmoNome();
        }

        protected override double TaxaValorMaximo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxaValorMinimo(Orcamento orcamento)
        {
            return orcamento.Items.Count * 0.01;
        }
    }
}
