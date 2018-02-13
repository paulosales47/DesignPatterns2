using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula03
{
    public class Estado
    {
        private DateTime _dataEstado;

        public DateTime DataEstado
        {
            get { return _dataEstado; }
        }

        private Contrato _contrato;

        public Contrato Contrato
        {
            get { return _contrato; }
            set { _contrato = value; }
        }

        public Estado(Contrato contrato)
        {
            _contrato = contrato;
            _dataEstado = DateTime.Now;
        }
    }
}
