using System;
namespace DesignPatterns.State
{
    public class Orcamento
    {
        public EstadoOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            EstadoAtual = new EmAprovacao();
        }

        public void AplicarDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
