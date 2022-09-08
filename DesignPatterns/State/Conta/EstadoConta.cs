using System;
namespace DesignPatterns.State.Conta
{
    public interface EstadoConta
    {
        public void Sacar(Conta conta, double valor);
        public void Depositar(Conta conta, double valor);
    }
}
