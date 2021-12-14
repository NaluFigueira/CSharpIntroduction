using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportacaoExportacao
{
    class MainClass
    {
        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.UTF8;

            var texto = utf8.GetString(buffer);

            Console.WriteLine(texto);
        }

        public static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024];

            var numeroDeBytesLidos = -1;


            while(numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
        }
    }
}
