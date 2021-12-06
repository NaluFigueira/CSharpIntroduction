using System;
namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                string exceptionMessage = "O argumento " + nameof(url) +
                    " não pode ser null ou uma string vazia.";
                throw new ArgumentException(exceptionMessage);
            } else if(url.StartsWith("https://www.bytebank.com.br/cambio?") == false)
            {
                throw new ArgumentException("URL não encontrada");
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);


            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            string termo = nomeParametro.ToUpper() + '=';

            int indiceParametro = argumentosEmCaixaAlta.IndexOf(termo);
            int indiceArgumento = indiceParametro + termo.Length;

            string valorDoArgumento = _argumentos.Substring(indiceArgumento);
            int indiceEComercial = valorDoArgumento.IndexOf('&');

            if (indiceEComercial > -1)
            {
                valorDoArgumento = valorDoArgumento.Remove(indiceEComercial);
            }

            return valorDoArgumento;
        }
    }
}
