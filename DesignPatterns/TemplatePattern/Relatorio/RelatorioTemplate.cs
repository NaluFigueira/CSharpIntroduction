using System;
using System.Collections.Generic;

namespace DesignPatterns.TemplatePattern.Relatorio
{
    public abstract class RelatorioTemplate
    {
        protected IEnumerable<Conta> Contas;

        public RelatorioTemplate(IEnumerable<Conta> contas)
        {
            Contas = contas;
        }

        public void ImprimirRelatorio()
        {
            Console.WriteLine(RecuperarCabecalho());


            foreach (var conta in Contas)
            {
                Console.WriteLine(FormatarConta(conta));
            }

                        
            Console.WriteLine(RecuperarRodape());
        }

        protected abstract string RecuperarCabecalho();
        protected abstract string FormatarConta(Conta conta);
        protected abstract string RecuperarRodape();
    }
}
