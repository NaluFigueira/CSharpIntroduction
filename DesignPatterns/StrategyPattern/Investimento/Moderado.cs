using System;
namespace DesignPatterns.StrategyPattern.Investimento
{
    public class Moderado : Investimento
    {
        private Random Random;

        public Moderado()
        {
            Random = new Random();
        }

        public double Calcula(Conta conta)
        {
            if (Random.Next(2) == 0)
                return conta.Saldo * 0.025;
            
            return conta.Saldo * 0.007;
        }
    }
}
