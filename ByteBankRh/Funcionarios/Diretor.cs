using System;
using ByteBankRh.Sistemas;

namespace ByteBankRh.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string CPF) : base(5000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
