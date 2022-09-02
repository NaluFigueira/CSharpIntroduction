using System;
namespace DesignPatterns.Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto()
        {
            OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
           return (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
        }
    }
}
