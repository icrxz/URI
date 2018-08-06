using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1930
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] qtd = Console.ReadLine().Split(' ');
            int tmds = int.Parse(qtd[0]) + int.Parse(qtd[1]) + int.Parse(qtd[2]) + int.Parse(qtd[3]);
            Console.WriteLine(tmds - 3);
            Console.ReadKey();
        }
    }
}
