using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Aula05;

namespace DesignPatterns2.Aula04
{
    public class Divisao: IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public IExpressao Esquerda
        {
            get { return _esquerda; }
        }

        public IExpressao Diretira
        {
            get { return _direita; }
        }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.VisitaDivisao(this);
        }

        public double Avalia()
        {
            double expEsquerda = _esquerda.Avalia();
            double expDireita = _direita.Avalia();

            return expEsquerda / expDireita;
        }
    }
}
