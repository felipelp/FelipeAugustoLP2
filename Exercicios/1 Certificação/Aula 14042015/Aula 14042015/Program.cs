using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14042015
{
    class Program
    {
        static void Main(string[] args)
        {

            int provas = 0;
            string[,] nadadores = new string[5, 2];
            int mt= 0;
            string bn = "";


            while (provas < 3)
            {
                for (int i = 0; i < 5; i++)
                {
                Console.Write("Nome: ");
                nadadores[i, 0] = Console.ReadLine();
                Console.Write("Tempo: ");
                nadadores[i, 1] = Console.ReadLine();

                if (mt == 0 || int.Parse(nadadores[i, 1]) < mt)
                {
                    mt = int.Parse(nadadores[i, 1]);
                    bn = nadadores[i, 0];
                }

                if (i == 4)
                {
                    provas++;
                    Console.WriteLine("Fim da prova");
                    Console.WriteLine("Menor tempo é de: {0} , pelo nadador: {1} ", mt, bn);
                }

                }

                
            }


            Console.WriteLine("Nadador campeão: {0}", bn);

            Console.ReadKey();
        }
    }
}
