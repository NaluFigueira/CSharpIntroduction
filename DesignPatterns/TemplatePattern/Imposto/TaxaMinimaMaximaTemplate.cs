using System;
namespace DesignPatterns.TemplatePattern
{
    public abstract class TaxaMinimaMaximaTemplate : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if(AtingiuValorMaximo(orcamento))
            {
                return TaxaValorMaximo(orcamento);
            }

            return TaxaValorMinimo(orcamento);
        }

        protected abstract bool AtingiuValorMaximo(Orcamento orcamento);
        protected abstract double TaxaValorMaximo(Orcamento orcamento);
        protected abstract double TaxaValorMinimo(Orcamento orcamento);
    }
}
