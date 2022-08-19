using System;
namespace DesignPatterns.ChainOfResponsibility
{
    public class DescontoParaValorMaior500 : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
