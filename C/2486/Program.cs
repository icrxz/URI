using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_2486
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd_comida = int.Parse(Console.ReadLine());
            while (qtd_comida != 0)
            {
                int cal = 0;
                for (int i = 0; i < qtd_comida; i++)
                {
                    string txt = Console.ReadLine();
                    int qtd = int.Parse(txt.Substring(0, txt.IndexOf(' ')));
                    string food = txt.Substring(txt.IndexOf(' ') + 1);
                    switch (food)
                    {
                        case "suco de laranja":
                            cal += (qtd * 120);
                            break;
                        case "morango fresco":
                            cal += (qtd * 85);
                            break;
                        case "mamao":
                            cal += (qtd * 85);
                            break;
                        case "goiaba vermelha":
                            cal += (qtd * 70);
                            break;
                        case "manga":
                            cal += (qtd * 56);
                            break;
                        case "laranja":
                            cal += (qtd * 50);
                            break;
                        case "brocolis":
                            cal += (qtd * 34);
                            break;
                    }
                }
                if (cal > 130)
                    Console.WriteLine("Menos {0} mg", cal - 130);
                else if (cal < 110)
                    Console.WriteLine("Mais {0} mg", 110 - cal);
                else
                    Console.WriteLine("{0} mg", cal);
                qtd_comida = int.Parse(Console.ReadLine());
            }
        }
    }
}
