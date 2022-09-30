using System;
namespace DesignPatterns.Bridge
{
    public interface IMensagem
    {
        public IEnviador Enviador { get; set; }

        public void Envia();

        public string Formata();
    }
}
