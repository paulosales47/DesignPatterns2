using DesignPatterns2.Aula01;
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
            var conexao = new ConnectionFactory();
            conexao.GetConnection();
        }
    }
}
