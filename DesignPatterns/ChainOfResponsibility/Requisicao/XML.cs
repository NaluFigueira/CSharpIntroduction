using System;
namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public class XML : Processador
    {

        public Processador Proximo { get ; set ; }

        public string Processa(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML) {
                return $"<ACCOUNT><OWNER>{conta.Titular}</OWNER><VALUE>{conta.Saldo}</VALUE></ACCOUNT>";
            }

            if (Proximo == null)
            {
                throw new Exception("Formato de resposta não encontrado");
            }

            return Proximo.Processa(requisicao, conta);
        }
    }
}
