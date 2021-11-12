namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int Agencia { get; set; }

        public int Numero { get; set; }

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
            Agencia = agencia;
            Numero = numero;
            Saldo = 100;

            ContaCorrente.TotalDeContasCriadas++;
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
