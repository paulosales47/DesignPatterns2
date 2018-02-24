using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Aula05;

namespace DesignPatterns2.Aula04
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao _expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            _expressao = expressao;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.VisitaRaizQuadrada(this);
        }

        public double Avalia()
        {
            return Math.Sqrt(_expressao.Avalia());
        }
    }
}
