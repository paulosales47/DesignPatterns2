using DesignPatterns2.Aula01;
using DesignPatterns2.Aula02;
using System;
using System.Collections.Generic;
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

            var notas = new NotasMusicais();

            IList<INota> musica = new List<INota>
            {
                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("mi"),
                notas.GetNota("fa"),
                notas.GetNota("fa"),
                notas.GetNota("fa"),

                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("re"),
                notas.GetNota("re"),

                notas.GetNota("do"),
                notas.GetNota("sol"),
                notas.GetNota("fa"),
                notas.GetNota("mi"),
                notas.GetNota("mi"),
                notas.GetNota("mi"),

                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("mi"),
                notas.GetNota("fa"),
                notas.GetNota("fa"),
                notas.GetNota("fa")
            };

            var piano = new Piano();
            piano.Toca(musica);

            #endregion Aula 2
        }
        
    }
}
