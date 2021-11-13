using System;
using ByteBankRh.Funcionarios;

namespace ByteBankRh
{
    class MainClass
    {
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor breno = new Desenvolvedor("538.468.020-26");
            breno.Nome = "Breno";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(breno);

            Console.WriteLine("Total bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void Main(string[] args)
        {

            CalcularBonificacao();
        }
    }
}
