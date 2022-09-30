using System;
namespace DesignPatterns.Singleton
{
    public class ServicoSingleton { 

        private static Servico instancia = new Servico();

        public Servico Instancia()
        {
            return instancia;
        }
    }
}
