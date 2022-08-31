using System;
namespace DesignPatterns.Decorator
{
    public class ICMS : Imposto
    {
        public ICMS() : base()
        {
        }

        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50 + CalculaOutroImposto(orcamento);
        }
    }
}
