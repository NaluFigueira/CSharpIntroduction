namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int Agencia { get; set; }

        public int Numero { get; set; }

        private double _saldo = 100;

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
