using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder.NotaFiscal
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public double ValorBruto { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public string Observacoes { get; private set; }
        public List<ItemDaNota> Itens = new List<ItemDaNota>();


        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComDataDeAgora()
        {
            DataEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            return this;
        }


        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, CNPJ, ValorBruto, DataEmissao, Observacoes, Itens);
        }
    }
}
