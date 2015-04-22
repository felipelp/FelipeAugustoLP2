using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31_03_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp, x;
            int r = 1;

            Console.Write("Número: ");
            exp = int.Parse(Console.ReadLine());
            Console.Write("Expoente: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                r *= exp;
            }

            Console.WriteLine("O resultado é {0}.", r);

            Console.ReadKey();
        }
    }
}
