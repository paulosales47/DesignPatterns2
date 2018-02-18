using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula04
{
    public class Numero: IExpressao
    {
        private double _numero;

        public Numero(double numero)
        {
            _numero = numero;
        }

        public double Avalia()
        {
            return _numero;
        }
    }
}
