using System;
using ByteBankRh.Funcionarios;

namespace ByteBankRh
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciadorBonificacao.Registrar(carlos);


            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciadorBonificacao.Registrar(roberta);

            Console.WriteLine("Total bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
