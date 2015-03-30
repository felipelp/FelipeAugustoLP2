using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "x";
            int vogais = 0;

            t = Console.ReadLine();

            for (int i = 0; i < t.Length; i++)
            {
                if (Convert.ToString(t[i]) == "a" || Convert.ToString(t[i]) == "e" || Convert.ToString(t[i]) == "i" || Convert.ToString(t[i]) == "o" || Convert.ToString(t[i]) == "u")
                {
                    vogais++;
                }
            }

            Console.WriteLine("Número de vogais: {0}", vogais);

            Console.ReadKey();
        }
    }
}
