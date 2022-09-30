using System;
namespace DesignPatterns.Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"Mensagem administrativa para {Nome}");
        }
    }
}
