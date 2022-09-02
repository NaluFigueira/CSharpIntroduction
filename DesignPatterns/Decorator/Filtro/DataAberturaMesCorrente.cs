using System;
namespace DesignPatterns.Decorator.Filtro
{
    public class DataAberturaMesCorrente : Filtro
    {
        public DataAberturaMesCorrente() : base()
        {

        }

        public DataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        protected override bool SeEncaixaNaCondicaoDoFiltro(Conta conta)
        {
            return conta.DataAbertura.Month == DateTime.Now.Month
                    && ValidaOutroFiltro(conta);
        }
    }
}
