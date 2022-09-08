using System;
using DesignPatterns.State.Conta;

namespace DesignPatterns.State.Conta
{
    public class Conta
    {
        public EstadoConta EstadoAtual { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
            EstadoAtual = new Positivo();
        }

        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }

        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this, valor);
        }
    }
}
