﻿using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value > 0)
                    _saldo = value;
                return;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agência deve ser maior que zero.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número deve ser maior que zero.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            Saldo = 100;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
            return false;
        }


    };
}
