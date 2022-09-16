using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public double ValorBruto { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public string Observacoes { get; private set; }
        public List<ItemDaNota> Itens { get; set; }

        public NotaFiscal(string razaoSocial, string cNPJ, double valorBruto, DateTime dataEmissao, string observacoes, List<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            ValorBruto = valorBruto;
            DataEmissao = dataEmissao;
            Observacoes = observacoes;
            Itens = itens;
        }
    }
}
