using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercicio_09_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int n = int.Parse(Console.ReadLine());

            int[] dn = new int[n];
            double[] s = new double[n];
            int[] cpf = new int[n];
            double[] sn = new double[n];
            int[] da = new int[n];
            string[] nome = new string[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");  nome[i] = Console.ReadLine();
                Console.Write("CPF: "); cpf[i] = int.Parse(Console.ReadLine());
                Console.Write("Data de nascimento: "); dn[i] = int.Parse(Console.ReadLine());
                Console.Write("Data de admissão: "); da[i] = int.Parse(Console.ReadLine());
                Console.Write("Salário: ");  s[i] = double.Parse(Console.ReadLine());

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
                Console.WriteLine("Nome: {0}", nome[i]);
                Console.WriteLine("CPF: {0}", cpf[i]);
                Console.WriteLine("Data de Nascimento: {0}", dn[i]);
                Console.WriteLine("Data de Admissão: {0}", da[i]);
                Console.WriteLine("Salário antigo: {0}", s[i]);
                Console.WriteLine("Novo salário: {0}", sn[i]);
            }
            */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Funcionario sujeito = new Funcionario();

                Console.Write("Nome: "); sujeito.nome = Console.ReadLine();

                Console.Write("CPF: "); sujeito.cpf = int.Parse(Console.ReadLine());

                Console.WriteLine("Data de nascimento: "); 
                Console.Write("Dia: "); int dia = int.Parse(Console.ReadLine()); 
                Console.Write("Mês: "); int mes = int.Parse(Console.ReadLine()); 
                Console.Write("Ano: "); int ano = int.Parse(Console.ReadLine());
                sujeito.dn = new DateTime(ano, mes, dia);

                Console.WriteLine("Data de admissão: ");
                Console.Write("Dia: "); dia = int.Parse(Console.ReadLine());
                Console.Write("Mês: "); mes = int.Parse(Console.ReadLine());
                Console.Write("Ano: "); ano = int.Parse(Console.ReadLine());
                sujeito.da = new DateTime(ano, mes, dia);

                Console.Write("Salário: "); sujeito.s = double.Parse(Console.ReadLine());

                sujeito.sn = sujeito.Calcula();

                Console.WriteLine("Por {0}, trabalhar na empresa desde {1}, seu salário foi de {2} para {3}", sujeito.nome, sujeito.da, sujeito.s, sujeito.sn);
                

            }

            Console.ReadKey();
        }
    }
}
