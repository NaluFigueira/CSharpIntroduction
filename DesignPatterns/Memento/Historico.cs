using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Memento
{
    public class Historico
    {
        private IList<Contrato> Contratos = new List<Contrato>();

        public Contrato RecuperarContrato(int index)
        {
            return Contratos.ElementAt(index);
        }

        public void SalvarContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }
    }
}
