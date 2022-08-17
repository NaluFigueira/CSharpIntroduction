using System;
namespace DesignPatterns.StrategyPattern.Investimento
{
    public class Arrojado : Investimento
    {
        private Random Random;

        public Arrojado()
        {
            Random = new Random();
        }

        public double Calcula(Conta conta)
        {
            int chances = Random.Next(100);

            if(chances < 30)
            {
                return conta.Saldo * 0.5;
            }

            if(chances >= 50)
            {
                return conta.Saldo * 0.006;
            }

            return conta.Saldo * 0.3;
        }
    }
}
