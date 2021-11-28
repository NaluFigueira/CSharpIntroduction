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
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);


            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            int indiceParametro = URL.IndexOf(nomeParametro);

            return URL.Substring(indiceParametro + nomeParametro.Length + 1);
        }
    }
}
