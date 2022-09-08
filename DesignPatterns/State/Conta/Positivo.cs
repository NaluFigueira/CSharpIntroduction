using System;
namespace DesignPatterns.State.Conta
{
    public class Positivo : EstadoConta
    {
        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Sacar(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if(conta.Saldo < 0)
            {
                conta.EstadoAtual = new Negativo();
            }
        }
    }
}
