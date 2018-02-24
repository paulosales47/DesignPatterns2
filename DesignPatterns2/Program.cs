using DesignPatterns2.Aula01;
using DesignPatterns2.Aula02;
using DesignPatterns2.Aula03;
using DesignPatterns2.Aula04;
using DesignPatterns2.Aula05;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula 1

            //var conexao = new ConnectionFactory();
            //conexao.GetConnection();

            #endregion Aula 1

            #region Aula 2

            //var notas = new NotasMusicais();

            //IList<INota> musica = new List<INota>
            //{
            //    notas.GetNota("do"),
            //    notas.GetNota("re"),
            //    notas.GetNota("mi"),
            //    notas.GetNota("fa"),
            //    notas.GetNota("fa"),
            //    notas.GetNota("fa"),

            //    notas.GetNota("do"),
            //    notas.GetNota("re"),
            //    notas.GetNota("do"),
            //    notas.GetNota("re"),
            //    notas.GetNota("re"),
            //    notas.GetNota("re"),

            //    notas.GetNota("do"),
            //    notas.GetNota("sol"),
            //    notas.GetNota("fa"),
            //    notas.GetNota("mi"),
            //    notas.GetNota("mi"),
            //    notas.GetNota("mi"),

            //    notas.GetNota("do"),
            //    notas.GetNota("re"),
            //    notas.GetNota("mi"),
            //    notas.GetNota("fa"),
            //    notas.GetNota("fa"),
            //    notas.GetNota("fa")
            //};

            //var piano = new Piano();
            //piano.Toca(musica);

            #endregion Aula 2

            #region Aula 3

            //var historico = new Historico();

            //Contrato contrato = new Contrato(DateTime.Now, "Paulo", TipoContrato.Novo);
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.AvancaStatus();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.AvancaStatus();
            //historico.Adiciona(contrato.SalvaEstado());

            //foreach (var estado in historico.ListaEstado)
            //{
            //    Console.WriteLine(estado.Contrato.Tipo + " | " + estado.DataEstado.ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture)); 
            //}

            #endregion Aula 3

            #region Aula 4

            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));

            //IExpressao conta = new Soma(esquerda, direita);
            //var resultado = conta.Avalia();
            //Console.WriteLine(resultado);

            #endregion Aula 4

            #region Aula 5

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);
            var resultado = conta.Avalia();
            Console.WriteLine(resultado);

            //Impressão
            var visitor = new ImprimeExpressaoVisitor();
            var visitorFixo = new ImprimeExpressaoFixaVisitor();
            conta.Aceita(visitor);
            conta.Aceita(visitorFixo);

            #endregion Aula 5




            Console.ReadKey();
        }

    }
}
