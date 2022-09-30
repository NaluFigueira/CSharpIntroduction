using System;
namespace DesignPatterns.Command
{
    public class FinalizarPedido : IComando
    {
        private Pedido Pedido;

        public FinalizarPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Pedido.Finaliza();
        }
    }
}
