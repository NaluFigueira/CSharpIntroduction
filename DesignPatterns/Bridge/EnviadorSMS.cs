using System;
namespace DesignPatterns.Bridge
{
    public class EnviadorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem abaixo por SMS:");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
