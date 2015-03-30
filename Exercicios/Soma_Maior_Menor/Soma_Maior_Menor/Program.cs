using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Maior_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double num = 0;
            double soma = 0;
            double maior = 0;
            double menor = 0;

            Console.Write("Qtd de números a ler: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                soma = num + soma;

                if (num > maior || menor == 0)
                {
                    maior = num;
                }
                if (num < menor || menor == 0)
                {
                    menor = num;
                }
                else { }

            }

            Console.WriteLine("Maior: {0} , Menor: {1}, Soma: {2}", maior, menor, soma);
            Console.ReadKey();
        }
    }
}
