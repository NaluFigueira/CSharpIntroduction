using System;
namespace DesignPatterns.StrategyPattern.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public Conta Conta { get; set; }
        public Investimento Investimento { get; set; }

        public RealizadorDeInvestimentos(Conta conta, Investimento investimento)
        {
            Conta = conta;
            Investimento = investimento;
        }

        public void Aplicar()
        {
            var retorno = Investimento.Calcula(Conta);

            Console.WriteLine($"Retorno do investimento: {retorno}");
            Console.WriteLine($"Valor adicionado ao saldo: {retorno*0.75}");
        }
    }
}
