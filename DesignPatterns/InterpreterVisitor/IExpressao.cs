using System;
using DesignPatterns.InterpreterVisitor;

namespace DesignPatterns.Interpreter
{
    public interface IExpressao
    {
        public int Avalia();

        public void Aceita(IVisitor visitor);
    }
}
