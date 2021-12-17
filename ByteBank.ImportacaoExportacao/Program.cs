using System;
using System.IO;
using System.Text;
using ByteBank.ImportacaoExportacao.Modelos;

namespace ByteBank.ImportacaoExportacao
{
    partial class MainClass
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78495,4785.50,Gustavo Santos";
                var enconding = Encoding.UTF8;
                var bytes = enconding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadasWriter.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,78495,4785.50,Gustavo Santos");
            }
        }

        static void Flush()
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // Despeja o buffer para o Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }

        static void EscritaBinaria()
        {
            var caminhoNovoArquivo = "escritaBinaria.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new BinaryWriter(fluxoDeArquivo))
            {
                escritor.Write(456);
                escritor.Write(546544);
                escritor.Write(4050.50);
                escritor.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var fluxoDeArquivo = new FileStream("escritaBinaria.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fluxoDeArquivo))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }

        public static void Main(string[] args)
        {
            EscritaBinaria();
            LeituraBinaria();
        }
    }
}
