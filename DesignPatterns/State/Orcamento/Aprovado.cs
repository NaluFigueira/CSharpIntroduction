using System;
namespace DesignPatterns.State
{
    public class Aprovado : EstadoOrcamento
    {
        private bool DescontoAplicado = false;

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DescontoAplicado = true;
            }
            else
            {
                throw new ApplicationException("Desconto já foi aplicado!");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível aprovar um orçamento já aprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível reprovar um orçamento já aprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
