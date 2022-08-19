using System;
namespace DesignPatterns.ChainOfResponsibility
{
    public class DescontoParaVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public bool AconteceuVendaCasada(Orcamento orcamento)
        {
            return orcamento.PossuiItem("LAPIS") && orcamento.PossuiItem("CANETA");
        }

        public double Calcula(Orcamento orcamento)
        {
            if(AconteceuVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
