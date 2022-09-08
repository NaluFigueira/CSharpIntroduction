using System;
namespace DesignPatterns.State.Conta
{
    public class Negativo : EstadoConta
    {
        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;

            if(conta.Saldo >= 0 )
            {
                conta.EstadoAtual = new Positivo();
            }
        }

        public void Sacar(Conta conta, double valor)
        {
            throw new ApplicationException("Não é possível sacar de uma conta com saldo negativo");
        }
    }
}
