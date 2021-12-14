using System;
namespace ByteBank.ImportacaoExportacao.Modelos
{
    public class ContaCorrente
    {
        public int Numero { get; }
        public int Agencia { get; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (Saldo < valor)
            {
                throw new InvalidOperationException("Saldo insuficiente");
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

       
        public override string ToString()
        {
            return $"Número {Numero}, Agência {Agencia}, Saldo {Saldo}";
        }
    }
}
