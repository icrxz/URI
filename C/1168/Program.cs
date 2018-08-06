using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1168
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int val;
            for (int i = 0; i < x; i++)
            {
                string entry = Console.ReadLine();
                val = 0;
                for (int j = 0; j < entry.Length; j++)
                {
                    switch (entry[j])
                    {
                        case '1':
                            val += 2;
                            break;
                        case '2':
                            val += 5;
                            break;
                        case '3':
                            val += 5;
                            break;
                        case '4':
                            val += 4;
                            break;
                        case '5':
                            val += 5;
                            break;
                        case '7':
                            val += 3;
                            break;
                        case '8':
                            val += 7;
                            break;
                        default:
                            val += 6;
                            break;
                    }
                }
                Console.WriteLine("{0} leds", val);
            }
            Console.ReadKey();
        }
    }
}
