using System;
namespace DesignPatterns.StrategyPattern.Investimento
{
    public interface Investimento
    {

        public double Calcula(Conta conta);
    }
}
