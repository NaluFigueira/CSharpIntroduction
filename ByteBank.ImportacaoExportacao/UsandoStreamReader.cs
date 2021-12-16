using System;
using System.IO;
using System.Text;
using ByteBank.ImportacaoExportacao.Modelos;

namespace ByteBank.ImportacaoExportacao
{
    partial class MainClass
    {

        public static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(' ');

            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ',')); ;

            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);

            var nomeTitular = campos[3];
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            resultado.Titular = titular;

            return resultado;

        }


        public static void UsandoStreamReader()
        {

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    Console.WriteLine(contaCorrente);
                }
            }
        }
    }
}
