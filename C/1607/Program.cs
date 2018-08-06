using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1607
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = int.Parse(Console.ReadLine());
            for (int j = 0; j < cont; j++)
            {
                string[] txt = Console.ReadLine().Split();
                string opt1 = txt[0];
                string opt2 = txt[1];
                char letra;
                int ope = 0;
                for (int i = 0; i < opt1.Length; i++)
                {
                    letra = opt1[i];
                    while (letra != opt2[i])
                    {
                        if (letra != 'z')
                            letra = (char)((int)letra + 1);
                        else
                            letra = 'a';
                        ope++;
                    }
                }
                Console.WriteLine(ope);
            }
            Console.ReadKey();
        }
    }
}
