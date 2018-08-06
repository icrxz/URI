using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_2651
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            if (txt.ToLower().Contains("zelda"))
                Console.WriteLine("Link Bolado");
            else
                Console.WriteLine("Link Tranquilo");
            Console.ReadLine();
        }
    }
}
