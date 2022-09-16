using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public double ValorBruto { get; private set; }
        public DateTime DataEmissao = DateTime.Now;
        public string Observacoes { get; private set; }
        public List<ItemDaNota> Itens = new List<ItemDaNota>();
        public List<AcaoAposCriarNota> Acoes = new List<AcaoAposCriarNota>();


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

        public NotaFiscalBuilder ComDataQualquer(DateTime data)
        {
            DataEmissao = data;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            return this;
        }

        public NotaFiscalBuilder AdicionaAcao(AcaoAposCriarNota acao)
        {
            Acoes.Add(acao);
            return this;
        }

        public NotaFiscal Constroi()
        {
            var nota = new NotaFiscal(RazaoSocial, CNPJ, ValorBruto, DataEmissao, Observacoes, Itens);
            foreach (var acao in Acoes)
            {
                acao.Executa(nota);
            }
            return nota;
        }
    }
}
