using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1183
{
    class Program
    {
        static void Main(string[] args)
        {
            char ope = Convert.ToChar(Console.ReadLine());
            double[,] matx = new double[12, 12];
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double aux = double.Parse(Console.ReadLine());
                    matx[i, j] = aux;
                    if (j > i)
                        sum += aux;
                }
            }
            if (ope == 'S')
                Console.WriteLine(sum.ToString("0.0"));
            else if (ope == 'M')
                Console.WriteLine((sum / 66).ToString("0.0"));
            Console.ReadKey();
        }
    }
}
