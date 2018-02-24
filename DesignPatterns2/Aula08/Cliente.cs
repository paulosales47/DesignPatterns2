using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula08
{
    public class Cliente
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private DateTime _dataNascimento;

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }
    }
}
