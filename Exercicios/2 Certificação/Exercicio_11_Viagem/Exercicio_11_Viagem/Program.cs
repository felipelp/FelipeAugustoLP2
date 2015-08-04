using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercicio_11_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {

            int carros;
            int id = 0;
            int op = 0;
            int n = 1;

            Console.Write("N de carros: "); carros = int.Parse(Console.ReadLine());

            ArrayList infcarros = new ArrayList();

            for (int i = 1; i < carros * 4 + 1; i++)
            {
                if (infcarros.Count % 5 == 0)
                {
                    id++;
                    infcarros.Add(id);
                }
                infcarros.Add(Console.ReadLine());
            }



            while (op == 0 || op != -1)
            {
                Console.Write("Em qual carro queres entrar? ");
                op = int.Parse(Console.ReadLine());
                n = 1;

                if (op > carros || op == 0)
                {
                    Console.WriteLine("Esse ID não existe");
                }

                for (int i = 1; i < carros + 1; i++)
                {
                    if (op == i)
                    {
                        n += (op - 1) * 5;
                        infcarros[n + 3] = Convert.ToInt32(infcarros[n + 3]) - 1;

                        if (Convert.ToInt32(infcarros[n + 3]) <= -1)
                        {
                            Console.WriteLine("Não há mais capacidade para entrar nesse carro!");
                            infcarros[n + 3] = Convert.ToInt32(infcarros[n + 3]) + 1;
                        }

                        else
                        {
                            Console.WriteLine("O carro {0} da marca {1}, possui agora {2} lugares.", infcarros[n], infcarros[n + 1], infcarros[n + 3]);

                        }
                    }
                }
            }

            string info = "ID: ";

            foreach (var item in infcarros)
            {
                
                
                Console.WriteLine(info + item);

                if (info == "ID: ")
                {
                    info = "Modelo: ";
                }
                else if (info == "Modelo: ")
                {
                    info = "Marca: ";
                }
                else if (info == "Marca: ")
                {
                    info = "Placa: ";
                }
                else if (info == "Placa: ")
                {
                    info = "Lugares disponíveis: ";
                }
                else if (info == "Lugares disponíveis: ")
                {
                    info = "ID: ";
                }
            }

            Console.ReadKey();
        }
    }
}
