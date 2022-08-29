using System;
namespace DesignPatterns.TemplatePattern.Relatorio
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }

        public Conta(string numero, string titular, double saldo, string agencia)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Agencia = agencia;
        }

    }
}
