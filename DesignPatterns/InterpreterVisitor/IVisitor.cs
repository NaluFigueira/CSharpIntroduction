using System;
using DesignPatterns.Interpreter;

namespace DesignPatterns.InterpreterVisitor
{
    public interface IVisitor
    {
        public void ImprimeSoma(Soma soma);
        public void ImprimeSubtracao(Subtracao subtracao);
        public void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        public void ImprimeDivisao(Divisao divisao);
        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
        public void ImprimeNumero(Numero numero);
    }
}
