using System;
namespace DesignPatterns.Memento
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; }
        public TipoContrato Tipo { get; set; }

        public Contrato(DateTime data, string nomeCliente, TipoContrato tipo = TipoContrato.NOVO)
        {
            Data = data;
            NomeCliente = nomeCliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            switch (Tipo)
            {
                case TipoContrato.NOVO:
                    Tipo = TipoContrato.EM_ANDAMENTO;
                    break;
                case TipoContrato.EM_ANDAMENTO:
                    Tipo = TipoContrato.ACERTADO;
                    break;
                case TipoContrato.ACERTADO:
                    Tipo = TipoContrato.CONCLUIDO;
                    break;
                default:
                    throw new Exception("Não foi possível avançar seu contrato, pois o estado atual é desconhecido ou já foi concluído");
            }
        }

        public void RestauraPara(Contrato versaoAnterior)
        {
            Data = versaoAnterior.Data;
            NomeCliente = versaoAnterior.NomeCliente;
            Tipo = versaoAnterior.Tipo;
        }
    }
}
