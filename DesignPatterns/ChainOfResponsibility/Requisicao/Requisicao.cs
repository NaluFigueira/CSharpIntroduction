using System;
namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public class Requisicao
    {
        public Formato Formato { get; set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
