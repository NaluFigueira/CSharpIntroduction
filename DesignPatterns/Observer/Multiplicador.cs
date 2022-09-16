using System;
namespace DesignPatterns.Observer
{
    public class Multiplicador : AcaoAposCriarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Valor: {notaFiscal.ValorBruto * Fator}");
        }
    }
}
