using System;
namespace DesignPatterns.Bridge
{
    public class EnviadorEmail : IEnviador
    {

        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem abaixo por e-mail:");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
