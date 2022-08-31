using System;
namespace DesignPatterns.Decorator
{
    public abstract class TaxaMinimaMaximaTemplate : Imposto
    {
        public TaxaMinimaMaximaTemplate() : base()
        {

        }

        public TaxaMinimaMaximaTemplate(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcula(Orcamento orcamento)
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
