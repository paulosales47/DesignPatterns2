using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Aula04;

namespace DesignPatterns2.Aula05
{
    public class ImprimeExpressaoFixaVisitor : IVisitor
    {
        public void VisitaDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write(" / ");
            divisao.Esquerda.Aceita(this);
            Console.Write("  ");
            divisao.Diretira.Aceita(this);
            Console.Write(")");
        }

        public void VisitaMutiplicacao(Mutiplicacao mutiplicacao)
        {
            Console.Write("(");
            Console.Write(" * ");
            mutiplicacao.Esquerda.Aceita(this);
            Console.Write("  ");
            mutiplicacao.Diretira.Aceita(this);
            Console.Write(")");
        }

        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void VisitaRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            throw new NotImplementedException("Função de impressão da raiz quadrada não implementada");
        }

        public void VisitaSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);
            Console.Write("  ");
            soma.Diretira.Aceita(this);
            Console.Write(")");
        }

        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);
            Console.Write("  ");
            subtracao.Diretira.Aceita(this);
            Console.Write(")");
        }
    }
}
