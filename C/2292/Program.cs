using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_2292
{
    class Program
    {
        static void Main(string[] args)
        {
            int vz = int.Parse(Console.ReadLine());
            for (int i = 0; i < vz; i++)
            {
                string[] str = Console.ReadLine().Split();
                StringBuilder txt = new StringBuilder(str[0]);
                int numChar = int.Parse(str[1])-1;
                if (txt[numChar] == 'X')
                    txt.Insert(numChar, 'O');
                else
                    txt.Insert(numChar, 'X');
                txt.Remove(numChar + 1, 1);
                Console.WriteLine(txt.ToString());
            }
            Console.ReadLine();
        }
    }
}
