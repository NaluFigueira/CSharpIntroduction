using System;
namespace DesignPatterns.Observer
{
    public class NotaFiscalDAO : AcaoAposCriarNota
    {
        void AcaoAposCriarNota.Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Persistindo no banco");
        }
    }
}
