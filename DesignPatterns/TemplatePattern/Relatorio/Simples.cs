using System;
using System.Collections.Generic;

namespace DesignPatterns.TemplatePattern.Relatorio
{
    public class Simples : RelatorioTemplate
    {
        public Simples(IEnumerable<Conta> contas) : base(contas)
        {
        }

        protected override string RecuperarCabecalho()
        {
            return "Banco Fictício";
        }

        protected override string FormatarConta(Conta conta)
        {
            return $"{conta.Titular} ; {conta.Saldo}";
        }

        protected override string RecuperarRodape()
        {
            return "(21) 2973-0923";
        }
    }
}
