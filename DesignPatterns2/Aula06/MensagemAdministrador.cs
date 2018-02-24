using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula06
{
    public class MensagemAdministrador : IMensagem
    {
        public IEnviador Enviador { get; set; }

        private string _nomeAdministrador;

        public MensagemAdministrador(string nomeAdministrador)
        {
            _nomeAdministrador = nomeAdministrador;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o administrador: {0}", _nomeAdministrador);
        }
    }
}
