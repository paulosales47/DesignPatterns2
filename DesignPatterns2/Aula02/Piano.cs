using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula02
{
    public class Piano
    {
        public void Toca(IList<INota> listaNota)
        {
            foreach (var nota in listaNota)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
