using System;
namespace DesignPatterns.Decorator
{
    public class MuitoAlto : Imposto
    {
        public MuitoAlto() : base()
        {
        }

        public MuitoAlto(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
        }
    }
}
