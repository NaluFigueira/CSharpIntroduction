using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            try
            {
                Cliente cliente = obj as Cliente;

                return CPF == cliente.CPF;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("O objeto comparado não é um cliente.");
                return false;
            }
        }
    }
}
