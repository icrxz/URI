using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_2356
{
    class Program
    {
        static void Main(string[] args)
        {
            string D;
            while (!String.IsNullOrEmpty((D = Console.ReadLine())))
            {
                string S = Console.ReadLine();
                if (D.Contains(S))
                    Console.WriteLine("Resistente");
                else
                    Console.WriteLine("Nao resistente");
            }
        }
    }
}
