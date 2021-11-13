using System;
namespace ByteBankRh.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string CPF) : base(2000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
