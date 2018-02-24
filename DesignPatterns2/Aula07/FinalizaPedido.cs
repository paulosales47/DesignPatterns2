using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula07
{
    public class FinalizaPedido : IComando
    {
        private Pedido _pedido;

        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando pedido do cliente: {0}", _pedido.NomeCliente);
            _pedido.Finaliza();
        }
    }
}
