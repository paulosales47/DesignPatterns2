using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula09
{
    public class Servico
    {
        private static readonly object padlock = new object();
        private static Servico instancia = null;

        private Servico() { }

        public Servico Instance()
        {
            lock (padlock)
            {
                if (instancia == null)
                {
                    instancia = new Servico();
                }
            }
            return instancia;
        }
    }
}
