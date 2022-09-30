using System;
namespace DesignPatterns.Bridge
{
    public interface IEnviador
    {
        public void Envia(IMensagem mensagem);
    }
}
