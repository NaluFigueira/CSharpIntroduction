using System;
namespace DesignPatterns.StrategyPattern
{
    public interface Imposto
    {
        public double Calcula(Orcamento orcamento);
    }
}
