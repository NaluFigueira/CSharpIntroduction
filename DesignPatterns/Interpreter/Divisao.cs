using System;
namespace DesignPatterns.Interpreter
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }
    }
}
