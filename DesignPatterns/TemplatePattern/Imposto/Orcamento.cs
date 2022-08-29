using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.TemplatePattern
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public List<Item> Items { get; private set; }

        public Orcamento()
        {
            Valor = 0;
            Items = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Items.Add(item);
            Valor += item.Valor;
        }


        public bool PossuiItemComValorMaiorA(double valor)
        {
            foreach (Item item in Items)
            {
                if (item.Valor > valor)
                    return true;
            }
            return false;
        }

        public bool PossuiItensComMesmoNome()
        {
            IList<string> noOrcamento = new List<string>();

            foreach (Item item in Items)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }

            return false;
        }
    }
}
