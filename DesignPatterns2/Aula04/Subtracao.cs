using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula04
{
    public class Subtracao: IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public double Avalia()
        {
            double expEsquerda = _esquerda.Avalia();
            double expDireita = _direita.Avalia();

            return expEsquerda - expDireita;
        }
    }
}
