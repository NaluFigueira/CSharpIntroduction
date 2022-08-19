using System;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns.ChainOfResponsibility
{
    public interface Desconto
    {
        public Desconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento);
    }
}
