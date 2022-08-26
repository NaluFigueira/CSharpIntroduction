using System;
namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

    }
}
