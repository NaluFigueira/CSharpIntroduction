using System;
namespace ByteBankRh.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string CPF) : base(4000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
