using System;
namespace DesignPatterns.Observer
{
    public class EnviadorEmail : AcaoAposCriarNota
    {
        void AcaoAposCriarNota.Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Enviando nota fiscal {notaFiscal.CNPJ}");
        }
    }
}
