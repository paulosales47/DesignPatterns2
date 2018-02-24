using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula07
{
    public class PagaPedido: IComando
    {
        private Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando pedido do cliente: {0}", _pedido.NomeCliente);
            _pedido.Paga();
        }
    }
}
