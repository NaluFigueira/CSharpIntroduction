using System;
namespace DesignPatterns.ChainOfResponsibility
{
    public class SemDesconto : Desconto
    {

        public Desconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return 0;
        }
    }
}
