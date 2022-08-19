using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
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


        public bool PossuiItem(String nomeDoItem)
        {
            foreach (Item item in Items)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
