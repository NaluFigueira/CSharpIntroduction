using System;
namespace ByteBankRh.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string CPF) : base(3000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
