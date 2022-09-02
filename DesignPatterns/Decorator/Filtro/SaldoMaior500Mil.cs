using System;
namespace DesignPatterns.Decorator.Filtro
{
    public class SaldoMaior500Mil : Filtro
    {
        public SaldoMaior500Mil() : base()
        {

        }

        public SaldoMaior500Mil(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        protected override bool SeEncaixaNaCondicaoDoFiltro(Conta conta)
        {
            return conta.Saldo > 500000 && ValidaOutroFiltro(conta);
        }
    }
}
