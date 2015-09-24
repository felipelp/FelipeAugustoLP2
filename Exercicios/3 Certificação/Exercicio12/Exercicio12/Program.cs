using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            double folha = 0;
            string funcionariotipo;

            Console.WriteLine("Informe a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            Terceirizado terceirizado = new Terceirizado();
            Trabalhador trabalhador = new Trabalhador();
            Gerente gerente = new Gerente();

            List<Terceirizado> terceirizados = new List<Terceirizado>();
            List<Trabalhador> trabalhadores = new List<Trabalhador>();
            List<Gerente> gerentes = new List<Gerente>();

            int ngerentes = 0;
            int ntrabalhadores = 0;
            int nterceirizados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Qual é o tipo do funcionário em questão? (trabalhador,gerente ou terceirizado?): ");
                funcionariotipo = Console.ReadLine();
                Console.WriteLine();

                if (funcionariotipo == "trabalhador")
                {
                   

                    Console.Write("Nome: ");
                    trabalhador.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    trabalhador.Cpf = Console.ReadLine();
                    Console.Write("Data de Nascimento: ");
                    trabalhador.DataNascimento = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    trabalhador.Matricula = Console.ReadLine();
                    Console.Write("Salário: ");
                    trabalhador.Salario = int.Parse(Console.ReadLine());
                    trabalhador.Vale = trabalhador.CalculaVale();

                    trabalhadores.Add(trabalhador);
                    ntrabalhadores++;
                    folha += trabalhador.Salario + trabalhador.Vale;
                }
                
                else if (funcionariotipo == "terceirizado")
                {
                    Console.Write("Nome: ");
                    terceirizado.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    terceirizado.Cpf = Console.ReadLine();
                    Console.Write("Data de Nascimento: ");
                    terceirizado.DataNascimento = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    terceirizado.Matricula = Console.ReadLine();
                    Console.Write("CNPJ da empresa do terceirizado: ");
                    terceirizado.Cnpj = Console.ReadLine();
                    Console.Write("Salário: ");
                    terceirizado.Salario = int.Parse(Console.ReadLine());

                    terceirizados.Add(terceirizado);
                    nterceirizados++;
                    folha += terceirizado.Salario;
                }

                

                else if (funcionariotipo == "gerente")
                {
                    Console.Write("Nome: ");
                    gerente.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    gerente.Cpf = Console.ReadLine();
                    Console.Write("Data de Nascimento: ");
                    gerente.DataNascimento = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    gerente.Matricula = Console.ReadLine();
                    Console.Write("Área de atuação: ");
                    gerente.AreaAtuacao = Console.ReadLine();
                    Console.Write("Salário: ");
                    gerente.Salario = int.Parse(Console.ReadLine());
                    gerente.Vale = gerente.CalculaVale();

                    gerentes.Add(gerente);
                    ngerentes++;
                    folha += gerente.Salario + gerente.Vale;
                }

            }


          
                Console.WriteLine("Folha de pagamento da empresa: {0}",folha);
            
            Console.ReadKey();
        }
    }
}
