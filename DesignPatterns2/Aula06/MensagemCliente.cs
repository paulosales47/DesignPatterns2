using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula06
{
    public class MensagemCliente: IMensagem
    {
        public IEnviador Enviador { get; set; }

        private string _nomeCliente;

        public MensagemCliente(string nomeCliente)
        {
            _nomeCliente = nomeCliente;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o cliente: {0}", _nomeCliente);
        }
    }
}
