using System;
namespace DesignPatterns.Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Valor { get; set; }

        public RaizQuadrada(IExpressao valor)
        {
            Valor = valor;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Valor.Avalia());
        }
    }
}
