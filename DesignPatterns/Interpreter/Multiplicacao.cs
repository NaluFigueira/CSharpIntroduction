using System;
namespace DesignPatterns.Interpreter
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() * Direita.Avalia();
        }
    }
}
