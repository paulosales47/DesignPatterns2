using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula07
{
    public class Pedido
    {
        private string _nomeCliente;

        private double _precoPedido;

        private Status _status;

        private DateTime _dtFinalizado;
        
        public string NomeCliente { get { return _nomeCliente; } }

        public double PrecoPedido { get { return _precoPedido; } }

        public Status StatusPedido { get { return _status; } }

        public DateTime DataFinalizacao { get { return _dtFinalizado; } }

        public Pedido(string nomeCliente, double precoCompra)
        {
            _nomeCliente = nomeCliente;
            _precoPedido = precoCompra;
            _status = Status.Novo;
        }

        public void Paga()
        {
            _status = Status.Pago;
        }

        public void Finaliza()
        {
            _status = Status.Entregue;
            _dtFinalizado = DateTime.Now;
        }
    }
}
