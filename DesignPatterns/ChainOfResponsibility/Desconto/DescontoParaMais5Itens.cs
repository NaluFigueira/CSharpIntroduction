using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DescontoParaMais5Itens : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if(orcamento.Items.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
