public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public bool Sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        return false;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir (double valor, ContaCorrente contaDestino)
    {
        if(this.saldo >= valor)
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
        return false;
    }
};