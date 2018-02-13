using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula03
{
    public class Historico
    {
        private IList<Estado> _listaEstado;

        public IList<Estado> ListaEstado
        {
            get { return _listaEstado; }
        }

        public Historico()
        {
            _listaEstado = new List<Estado>();
        }

        public void Adiciona(Estado estado)
        {
            _listaEstado.Add(estado);
        }
    }
}
