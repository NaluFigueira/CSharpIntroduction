using System;
namespace DesignPatterns.State
{
    public class Finalizado : EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível aplicar desconto em um orçamento já finalizado");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível aprovar um orçamento já finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível reprovar um orçamento já finalizado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new ApplicationException("Não é possível finalizar um orçamento já finalizado");
        }
    }
}
