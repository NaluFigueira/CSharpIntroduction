using System;
namespace DesignPatterns.StrategyPattern.Investimento
{
    public class Conta
    {
        public double Saldo { get; set; }

        public Conta()
        {
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
