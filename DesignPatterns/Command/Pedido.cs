using System;
namespace DesignPatterns.Command
{
    public enum StatusPedido
    {
        NOVO,
        PAGO,
        ENTREGUE
    }

    public class Pedido
    {
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public StatusPedido Status { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = StatusPedido.NOVO;
        }

        public void Paga()
        {
            Status = StatusPedido.PAGO;
        }

        public void Finaliza()
        {
            Status = StatusPedido.ENTREGUE;
            DataFinalizacao = DateTime.Now;
        }
    }
}
