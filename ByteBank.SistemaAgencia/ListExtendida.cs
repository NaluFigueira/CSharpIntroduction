using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtendida
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void EscreverListaNaTela<T>(this List<T> lista, params T[] itens)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Lista[{i}] = {lista[i]}");
            }
        }

    }
}
