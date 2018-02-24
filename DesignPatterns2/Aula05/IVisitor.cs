using DesignPatterns2.Aula04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula05
{
    public interface IVisitor
    {
        void VisitaSoma(Soma soma);

        void VisitaSubtracao(Subtracao subtracao);

        void VisitaDivisao(Divisao divisao);

        void VisitaMutiplicacao(Mutiplicacao mutiplicacao);

        void VisitaNumero(Numero numero);

        void VisitaRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}
