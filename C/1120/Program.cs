using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace URI_1120
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            string[] options = entry.Split();
            while (options[0] != "0" || options[1] != "0")
            {
                options[1] = options[1].Replace(options[0], "");
                options[1] = options[1].TrimStart('0').TrimEnd();
                if (string.IsNullOrEmpty(options[1]))
                    options[1] = "0";
                Console.WriteLine(options[1]);
                entry = Console.ReadLine();
                options = entry.Split();
            }
        }
    }
}
