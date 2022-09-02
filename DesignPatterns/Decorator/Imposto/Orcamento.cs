using System;
using System.Collections.Generic;

namespace DesignPatterns.Decorator
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
    }
}
