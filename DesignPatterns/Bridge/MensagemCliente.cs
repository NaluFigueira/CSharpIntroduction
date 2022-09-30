using System;
namespace DesignPatterns.Bridge
{
    public class MensagemCliente : IMensagem
    {
        private string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Mensagem para o cliente {Nome}");
        }
    }
}
