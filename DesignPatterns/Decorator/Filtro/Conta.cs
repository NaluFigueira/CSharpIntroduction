using System;
namespace DesignPatterns.Decorator.Filtro
{
    public class Conta
    {
        public double Saldo { get; set; }

        public DateTime DataAbertura { get; set; }

        public string Titular { get; set; }

        public Conta(string titular)
        {
            Saldo = 0;
            DataAbertura = DateTime.Now;
            Titular = titular;
        }
    }
}
