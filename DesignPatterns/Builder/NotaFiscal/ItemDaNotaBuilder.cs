using System;
namespace DesignPatterns.Builder.NotaFiscal
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            Descricao = descricao;

            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;

            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}
