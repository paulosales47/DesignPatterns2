using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula07
{
    public class FilaExecucaoPedido
    {
        private IList<IComando> _listaComando;

        public FilaExecucaoPedido()
        {
            _listaComando = new List<IComando>();
        }

        public void Adiciona(IComando comando)
        {
            _listaComando.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in _listaComando)
            {
                comando.Executa();
            }
        }


    }
}
