using System;
using System.Collections.Generic;

namespace DesignPatterns.TemplatePattern.Relatorio
{
    public class Complexo : RelatorioTemplate
    {
        public Complexo(IEnumerable<Conta> contas) : base(contas)
        {
        }

        protected override string RecuperarCabecalho()
        {
            return "Banco Fictício  Rua Três, 838, Lagoinha, Nova Iguaçu, RJ    (21) 2973-0923";
        }

        protected override string FormatarConta(Conta conta)
        {
            return $"{conta.Titular} ; {conta.Agencia} ; {conta.Numero} ; {conta.Saldo}";
        }

        protected override string RecuperarRodape()
        {
            return $"contato@bancoficticio.com.br    {DateTime.Now}";
        }
    }
}
