using System;
namespace ByteBankRh.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string CPF) : base(3000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
