using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] txt = Console.ReadLine().Split();
                int horas = int.Parse(txt[2]) - int.Parse(txt[0]);
                int min = int.Parse(txt[3]) - int.Parse(txt[1]);
                if (horas <= 0 && min <= 0)
                    horas += 24;
                if (min < 0)
                {
                    horas--;
                    min = 60 + min;
                }

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, min);
            }
        }
    }
}
