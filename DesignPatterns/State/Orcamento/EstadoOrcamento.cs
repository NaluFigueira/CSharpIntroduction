using System;
namespace DesignPatterns.State
{
    public interface EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento);
        public void Aprovar(Orcamento orcamento);
        public void Reprovar(Orcamento orcamento);
        public void Finalizar(Orcamento orcamento);
    }
}
