using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace URI_1024
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            string texto, txtAux;
            Regex regex = new Regex(@"[a-zA-Z]");
            for (int i = 0; i < qtd; i++)
            {
                texto = Console.ReadLine();
                txtAux = string.Empty;
                int cont = (int)Math.Truncate((double)texto.Length / 2);
                if (texto.Length % 2 == 0)
                    cont -= 1;
                for (int j = 0; j < texto.Length; j++)
                {
                    if (j <= cont)
                    {
                        if (regex.IsMatch(Convert.ToString(texto[j])))
                            txtAux += Convert.ToChar((int)texto[j] + 2);
                        else
                            txtAux += Convert.ToChar((int)texto[j] - 1);
                    }
                    else
                    {
                        if (regex.IsMatch(Convert.ToString(texto[j])))
                            txtAux += Convert.ToChar((int)texto[j] + 3);
                        else
                            txtAux += texto[j];
                    }
                }
                char[] arr = txtAux.ToCharArray();
                Array.Reverse(arr);
                txtAux = new string(arr);
                Console.WriteLine(txtAux);
            }
            Console.ReadLine();
        }
    }
}
