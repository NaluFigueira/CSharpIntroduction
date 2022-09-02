using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Decorator.Filtro
{
    public abstract class Filtro
    {
        private Filtro OutroFiltro { get; set; }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        protected bool ValidaOutroFiltro(Conta conta)
        {
            return (OutroFiltro == null ? true : OutroFiltro.SeEncaixaNaCondicaoDoFiltro(conta));
        }

        public IList<Conta> Filtra(IList<Conta> contas)
        {
            var contasFiltradas = new List<Conta>();

            foreach (var conta in contas)
            {
                if(SeEncaixaNaCondicaoDoFiltro(conta))
                {
                    contasFiltradas.Add(conta);
                }
            }

            return contasFiltradas;
        }

        public void ExibirListaFiltrada(IList<Conta> contas)
        {
            var contasFiltradas = Filtra(contas);

            Console.WriteLine($"Contas filtradas:");

            foreach (var conta in contasFiltradas)
            {
                Console.WriteLine($"{conta.Titular}, {conta.Saldo}");
            }
        }

        protected abstract bool SeEncaixaNaCondicaoDoFiltro(Conta conta);
    }
}
