using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1188
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mtz = new double[12, 12];
            double sum = 0;
            char ope = char.Parse(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double num = double.Parse(Console.ReadLine());
                    mtz[i, j] = num;
                    if (j > i && j < 11 - i)
                    {
                        sum += num;
                    }
                }
            }
            if (ope == 'S')
                Console.WriteLine(sum.ToString("0.0"));
            else if (ope == 'M')
                Console.WriteLine((sum / 30).ToString("0.0"));
            Console.ReadKey();

        }
    }
}
