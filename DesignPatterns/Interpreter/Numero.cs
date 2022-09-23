using System;
namespace DesignPatterns.Interpreter
{
    public class Numero : IExpressao
    {
        public int Num { get; set; }

        public Numero(int num)
        {
            Num = num;
        }

        public int Avalia()
        {
            return Num;
        }
    }
}
