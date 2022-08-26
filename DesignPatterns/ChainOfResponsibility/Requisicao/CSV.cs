using System;
namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public class CSV : Processador
    {
        public Processador Proximo { get; set; }

        public string Processa(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.CSV)
            {
                return $"{conta.Titular};{conta.Saldo}";
            }

            if (Proximo == null)
            {
                throw new Exception("Formato de resposta não encontrado");
            }

            return Proximo.Processa(requisicao, conta);
        }
    }
}
