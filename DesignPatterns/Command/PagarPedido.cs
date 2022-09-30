using System;
namespace DesignPatterns.Command
{
    public class PagarPedido : IComando
    {
        private Pedido Pedido;

        public PagarPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Pedido.Paga();
        }
    }
}
