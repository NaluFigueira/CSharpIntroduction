using System;
namespace ByteBankRh.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * .1;
        }
    }
}
