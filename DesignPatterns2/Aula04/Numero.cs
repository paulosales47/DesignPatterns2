using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Aula05;

namespace DesignPatterns2.Aula04
{
    public class Numero: IExpressao
    {
        private double _numero;

        public Numero(double numero)
        {
            _numero = numero;
        }

        public double Valor
        {
            get { return _numero; }
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.VisitaNumero(this);
        }

        public double Avalia()
        {
            return _numero;
        }
    }
}
