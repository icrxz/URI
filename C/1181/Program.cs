using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1181
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[12, 12];
            double res = 0, num = 0;
            int l = int.Parse(Console.ReadLine());
            char t = char.Parse(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    num = double.Parse(Console.ReadLine());
                    mat[i, j] = num;
                    if (i == l)
                        res += num;
                }
            }
            if (t == 'M')
                res /= 12;
            Console.WriteLine(res.ToString("0.0"));
            Console.ReadKey();
        }
    }
}
