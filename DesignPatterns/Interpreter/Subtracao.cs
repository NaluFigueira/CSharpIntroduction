using System;
namespace DesignPatterns.Interpreter
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() - Direita.Avalia();
        }
    }
}
