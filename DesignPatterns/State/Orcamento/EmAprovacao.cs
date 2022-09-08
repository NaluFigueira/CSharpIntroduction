using System;
namespace DesignPatterns.State
{
    public class EmAprovacao : EstadoOrcamento
    {
        private bool DescontoAplicado = false;

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoAplicado = true;
            }
            else
            {
                throw new ApplicationException("Desconto já foi aplicado!");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível finalizar um orçamento em aprovação");
        }

    }
}
