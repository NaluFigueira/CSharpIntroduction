using System;
namespace DesignPatterns.Decorator.Filtro
{
    public class SaldoMenor100 : Filtro
    {
        public SaldoMenor100() : base()
        {

        }

        public SaldoMenor100(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        protected override bool SeEncaixaNaCondicaoDoFiltro(Conta conta)
        {
            return conta.Saldo < 100 && ValidaOutroFiltro(conta);
        }
    }
}
