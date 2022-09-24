using System;
using DesignPatterns.Interpreter;

namespace DesignPatterns.InterpreterVisitor
{
    public class VisitorPreFixo : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write("/");
            divisao.Esquerda.Aceita(this);
            Console.Write(" ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            Console.Write("*");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Num);
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.Write("sqrt(");
            raizQuadrada.Valor.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
