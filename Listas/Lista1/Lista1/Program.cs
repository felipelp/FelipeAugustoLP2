using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            exercicio1();
            exercicio2();
            exercicio3();
            exercicio4();
            exercicio5();
            exercicio6();
            exercicio7();
            exercicio8();
            Console.ReadKey();
        }


        //FATORIAL
        static int fatorial(int n)
        {
            for (int i = n - 1; i != 0; i--)
            {
                n = n * i;
            }
            return n;
        }



        ///////////////FUNÇÃO EXERCÍCIO 1//////////////
        static void exercicio1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 1.");
            Console.ResetColor();
            Console.Write("Digite o fatorial a calcular: ");
            int n = int.Parse(Console.ReadLine());
            int rf = fatorial(n);
            Console.WriteLine("Fatorial de {0} = {1}", n, rf);
            Console.WriteLine(" ");
        }



        ///////////////FUNÇÃO EXERCÍCIO 2//////////////
        static void exercicio2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 2.");
            Console.ResetColor();

            int num = 0;
            int db = 1;
            double resultado;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num + 1; i++)
            {
                if (i % 2 == 0)
                {
                    resultado = fatorial(i) / db;
                    Console.Write(" - {0}/{1}", fatorial(i), db);
                    db = (db * 2 + 1) * 1;
                }
                else
                {
                    resultado = fatorial(i) / db;
                    Console.Write(" + {0}/{1}", fatorial(i), db);
                    db = (db * 2 + 1) * 1;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }



        ///////////////FUNÇÃO EXERCÍCIO 3//////////////
        static void exercicio3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 3.");
            Console.ResetColor();

            int f = 0;
            Console.Write("Digite o número de funcionários: ");
            f = int.Parse(Console.ReadLine());

            string[] funcionarios = new string[f];
            double[] salarios = new double[f];

            for (int i = 0; i < f; i++)
            {
                Console.Write("Nome do funcionário {0}: ", i + 1);
                funcionarios[i] = Console.ReadLine();
                Console.Write("Salário do funcionário {0}: ", i + 1);
                salarios[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("Funcionário 1: {0}, Salário: {1}", funcionarios[i], salarios[i]);
            }
            for (int i = 0; i < f; i++)
            {
                if (salarios[i] < 2999)
                {
                    Console.WriteLine("{0} ganhou um ajuste de 25%! Seu salário era: {1}, e seu novo salário agora é: {2}", funcionarios[i], salarios[i], salarios[i] += (salarios[i] / 100) * 25);
                }
                else if (salarios[i] > 2999 && salarios[i] < 3999)
                {
                    Console.WriteLine("{0} ganhou um ajuste de 20%! Seu salário era: {1}, e seu novo salário agora é: {2}", funcionarios[i], salarios[i], salarios[i] += (salarios[i] / 100) * 20);
                }
                else if (salarios[i] > 3999 && salarios[i] < 4999)
                {
                    Console.WriteLine("{0} ganhou um ajuste de 15%! Seu salário era: {1}, e seu novo salário agora é: {2}", funcionarios[i], salarios[i], salarios[i] += (salarios[i] / 100) * 15);
                }
                else if (salarios[i] > 4999)
                {
                    Console.WriteLine("{0} ganhou um ajuste de 10%! Seu salário era: {1}, e seu novo salário agora é: {2}", funcionarios[i], salarios[i], salarios[i] += (salarios[i] / 100) * 10);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }






        ///////////////FUNÇÃO EXERCÍCIO 4//////////////
        static void exercicio4()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 4.");
            Console.ResetColor();

            int player1 = 0;
            int player2 = 0;
            string ponto = "";
            while (player1 != 21 || player2 != 21 || (player1 == 21 && player2 == 21))
            {

                Console.Write("Faça uma jogada! Para o jogador 1 pontuar, digite: p1, para o jogador 2 pontuar, digite p2: ");
                ponto = Console.ReadLine();

                if (ponto == "p1")
                {
                    player1++;
                    Console.WriteLine("Placar: Jogador 1 [{0}] x [{1}] Jogador 2", player1, player2);
                    if (player1 == 21 && player2 <= player1 - 2)
                    {
                        Console.WriteLine("Jogador 1 venceu");
                        break;
                    }
                    else if (player1 == 21 && player2 > player1 - 2)
                    {
                        Console.WriteLine("O player 1 tem uma diferença inferior a 2 pontos, pontua mais para vencer");
                    }
                    else if (player1 > 21 && player2 <= player1 - 2)
                    {
                        Console.WriteLine("Jogador 1 venceu");
                        break;
                    }
                }
                else if (ponto == "p2")
                {
                    player2++;
                    Console.WriteLine("Placar: Jogador 1 [{0}] x [{1}] Jogador 2", player1, player2);
                    if (player2 == 21 && player1 <= player2 - 2)
                    {
                        Console.WriteLine("Jogador 2 venceu");
                        break;
                    }
                    else if (player2 == 21 && player1 > player2 - 2)
                    {
                        Console.WriteLine("O player 2 tem uma diferença inferior a 2 pontos, pontua mais para vencer");
                    }
                    else if (player2 > 21 && player1 <= player2 - 2)
                    {
                        Console.WriteLine("Jogador 2 venceu");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro, para o jogador 1 pontuar, digite: p1, para o jogador 2 pontuar, digite p2");
                }
            }
        }



        ///////////////FUNÇÃO EXERCÍCIO 5//////////////
        static void exercicio5()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 5.");
            Console.ResetColor();

            int kms = 0;
            int litros = 50;
            int litrosuso = 0;
            string op = "";
            bool percurso = true;
            double media = 0;

            while (percurso == true)
            {
                Console.Write("Digite quantos KM's foram percorridos: ");
                kms += int.Parse(Console.ReadLine());

                Console.Write("Digite quantos litros foram gastos até aqui: ");
                litrosuso += int.Parse(Console.ReadLine());

                if (litrosuso > 50)
                {
                    litrosuso = 0;
                    Console.WriteLine("Erro! O carro só tem 50 litros disponíveis.");
                    Console.Write("Digite quantos litros foram gastos até aqui: ");
                    litrosuso += int.Parse(Console.ReadLine());
                }
                litros -= litrosuso;

                if (litrosuso != 0)
                {
                    media = kms / litrosuso;
                }
                else if (litrosuso == 0)
                {
                    media = 12;
                }

                if (kms >= 600)
                {
                    percurso = false;
                    Console.WriteLine("Fim do percurso, o carro teve um desempenho médio de {0}KM/L", media);
                }
                else if (litrosuso >= 50)
                {
                    Console.WriteLine("A gasolina acabou.");
                    Console.WriteLine("O carro teve um desempenho médio de {0}KM/L", media);
                    break;
                }
            }
        }



        ///////////////FUNÇÃO EXERCÍCIO 6//////////////
        static void exercicio6()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 6.");
            Console.ResetColor();

            SortedList m = new SortedList();
            string nome = "";
            int cm = 0;
            int maioraltura = 0;
            int smaioraltura = 0;
            int mocas = 0;

            while (nome != "FIM")
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                if (nome != "FIM")
                {
                    Console.Write("Altura em cm: ");
                    cm = int.Parse(Console.ReadLine());

                    m.Add(nome, cm);
                }
            }

            foreach (DictionaryEntry valor in m)
            {
                Console.WriteLine("Nome = {0}, Altura = {1}", valor.Key, valor.Value);

                if (maioraltura == 0)
                {
                    maioraltura = (int)valor.Value;
                }
                else if (smaioraltura == 0)
                {
                    smaioraltura = (int)valor.Value;
                }




                else if ((int)valor.Value >= maioraltura && smaioraltura < maioraltura)
                {
                    smaioraltura = maioraltura;
                }

                else if ((int)valor.Value >= maioraltura)
                {
                    maioraltura = (int)valor.Value;
                }

                else if ((int)valor.Value >= smaioraltura)
                {
                    smaioraltura = (int)valor.Value;
                }




                else
                {
                    maioraltura = maioraltura;
                }
            }

            foreach (DictionaryEntry alt in m)
            {
                if ((int)alt.Value == maioraltura || (int)alt.Value == smaioraltura)
                {
                    mocas++;
                }
            }
            Console.WriteLine("As duas maiores alturas são: {0} e {1} , e {2} moças as possuem. ", maioraltura, smaioraltura, mocas);
        }



        ///////////////FUNÇÃO EXERCÍCIO 7//////////////
        static void exercicio7()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 7.");
            Console.ResetColor();


            int nprova = 0;
            int nadadores = 0;
            int ca = 0;
            int cb = 0;




            while (nprova != 9999 && nadadores != 0 || nprova == 0)
            {

                Console.Write("Número da prova: ");
                nprova = int.Parse(Console.ReadLine());

                Console.Write("Número de nadadores: ");
                nadadores = int.Parse(Console.ReadLine());
                string[,] nadador = new string[nadadores, 4];

                for (int i = 0; i < nadadores; i++)
                {
                    Console.Write("Nadador {0}: ", i + 1);
                    nadador[i, 0] = Console.ReadLine();

                    Console.Write("Classificação do nadador {0}: ", i + 1);
                    nadador[i, 1] = Console.ReadLine();

                    Console.Write("Tempo do nadador {0}: ", i + 1);
                    nadador[i, 2] = Console.ReadLine();

                    Console.Write("Clube do nadador (A ou B) {0}: ", i + 1);
                    nadador[i, 3] = Console.ReadLine();

                    if (nadador[i, 3] == "A" && nadador[i, 1] == "1")
                    {
                        ca += 9;
                    }
                    else if (nadador[i, 3] == "A" && nadador[i, 1] == "2")
                    {
                        ca += 6;
                    }
                    else if (nadador[i, 3] == "A" && nadador[i, 1] == "3")
                    {
                        ca += 4;
                    }
                    else if (nadador[i, 3] == "A" && nadador[i, 1] == "4")
                    {
                        ca += 3;
                    }
                    else if (nadador[i, 3] == "B" && nadador[i, 1] == "1")
                    {
                        cb += 9;
                    }
                    else if (nadador[i, 3] == "B" && nadador[i, 1] == "2")
                    {
                        cb += 6;
                    }
                    else if (nadador[i, 3] == "B" && nadador[i, 1] == "3")
                    {
                        cb += 4;
                    }
                    else if (nadador[i, 3] == "B" && nadador[i, 1] == "4")
                    {
                        cb += 3;
                    }
                }

                if (nprova != 9999)
                {
                    Console.WriteLine("Número da prova: {0}, Placar: Clube A: {1}, Clube B: {2}", nprova, ca, cb);
                }

            }

            if (ca > cb)
            {
                Console.WriteLine("Clube A é o vencedor!");
            }
            else if (cb > ca)
            {
                Console.WriteLine("Clube B é o vencedor!");
            }
            else
            {
                Console.WriteLine("Houve empate entre o Clube A e B");
            }

        }



        ///////////////FUNÇÃO EXERCÍCIO 8//////////////
        static void exercicio8()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exercício 8.");
            Console.ResetColor();

            int numero = 0;
            int soma = 0;

            Console.Write("N: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero + 1; i++)
            {
                soma += i;
            }

            Console.WriteLine(soma);
        }

        //
    }
}
