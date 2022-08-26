using System;
namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public interface Processador
    {
        public Processador Proximo { get; set; }

        public string Processa(Requisicao requisicao, Conta conta);
    }
}
