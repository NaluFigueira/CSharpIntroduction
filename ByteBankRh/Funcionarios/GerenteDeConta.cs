using System;
using ByteBankRh.Sistemas;

namespace ByteBankRh.Funcionarios
{
    public class GerenteDeConta : Autenticavel
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
