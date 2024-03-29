﻿using System;
namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Saldo está abaixo do valor solicitado (" + valorSaque + " reais).")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {
        }
    }
}
