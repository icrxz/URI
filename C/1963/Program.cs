using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1963
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            string[] input = Console.ReadLine().Split(' ');
            A = double.Parse(input[0]);
            B = double.Parse(input[1]);
            Console.WriteLine((((B / A) * 100) - 100).ToString("0.00") + '%');
            Console.ReadLine();
        }
    }
}
