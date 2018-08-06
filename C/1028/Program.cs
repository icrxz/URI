using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1028
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, num1, num2, div = 1;
            string[] input;
            casos = int.Parse(Console.ReadLine());
            for (int i = 0; i < casos; i++)
            {
                input = Console.ReadLine().Split(' ');
                num1 = int.Parse(input[0]);
                num2 = int.Parse(input[1]);
                while (num2 != 0)
                {
                    div = num1 % num2;
                    num1 = num2;
                    num2 = div;
                }
                Console.WriteLine(num1);
            }
            Console.ReadKey();
        }
    }
}
