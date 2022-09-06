using System;
namespace DesignPatterns.State
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível aplicar desconto em um orçamento já reprovado");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível aprovar um orçamento já reprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível reprovar um orçamento já reprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
