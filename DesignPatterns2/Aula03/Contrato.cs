using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula03
{
    public class Contrato
    {
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
        }

        private string _cliente;

        public string Cliente
        {
            get { return _cliente; }
        }

        private TipoContrato _tipo;

        public TipoContrato Tipo
        {
            get { return _tipo; }
        }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            _data = data;
            _cliente = cliente;
            _tipo = tipo;
        }

        public void AvancaStatus()
        {
            if (this.Tipo == TipoContrato.Novo) this._tipo = TipoContrato.EmAndamento;
            else if (this.Tipo == TipoContrato.EmAndamento) this._tipo = TipoContrato.Acertado;
            else if (this.Tipo == TipoContrato.Acertado) this._tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(_data, _cliente, _tipo));
        }
        

    }
}
