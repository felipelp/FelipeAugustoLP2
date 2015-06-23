using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Felipes_Augusto_e_Ribeiro_23._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                               
            int[] dn = new int[n];
            double[] s = new double[n];
            int[] cpf = new int[n];
            double[] sn = new double[n];
            int[] da = new int[n];
            string[] nome = new string[n];


            for (int i = 0; i < n; i++)
            {
                nome[i] = Console.ReadLine();
                cpf[i] = int.Parse(Console.ReadLine());
                dn[i] = int.Parse(Console.ReadLine());
                da[i] = int.Parse(Console.ReadLine());
                s[i] = double.Parse(Console.ReadLine());

                if (da[i] >= 2014)
                {
                    sn[i] = s[i] + 423.45;
                }
                
                else if (da[i] >= 2000 && da[i] <= 2010)
                {
                    sn[i] = s[i] + (s[i] * 16.4 / 100);
                }
               
                else if (da[i] < 2000)
                {
                    sn[i] = s[i] + (s[i] * 22.6 / 100);
                }
                
                else if (da[i] >= 2010 && da[i] <= 2013)
                {
                    sn[i] = s[i] + (s[i] * 9.84 / 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("CPF: " + cpf[i]);
                Console.WriteLine("Data de Nascimento: " + dn[i]);
                Console.WriteLine("Data de Admição: " + da[i]);
                Console.WriteLine("Salario Atual: " + s[i]);
                Console.WriteLine("Novo Salario: " + sn[i]);

           }

        }
    }
}
