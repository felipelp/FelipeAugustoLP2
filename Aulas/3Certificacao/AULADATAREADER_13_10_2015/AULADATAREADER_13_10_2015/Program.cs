using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace AULADATAREADER_13_10_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pessoa> pessoas = new List<pessoa>();
            Console.Write("Adicionar(1) , consultar dados(2) , sair(3): ");
            int op = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            while (op != 1 && op != 2 && op != 3)
            {
                Console.Write("Escolha 1 , 2 ou 3: ");
                op = int.Parse(Console.ReadLine());

            }
                while (op != 3 && op == 1 || op == 2)
                {
                    if (op == 1)
                    {
                        pessoa x = new pessoa();
                        Console.Write("Nome: "); x.nome = Console.ReadLine();
                        Console.Write("Sobrenome: "); x.sobrenome = Console.ReadLine();
                        Console.Write("Peso: "); x.peso = double.Parse(Console.ReadLine());
                        Console.Write("Altura: "); x.altura = double.Parse(Console.ReadLine());
                        Console.Write("Telefone: "); x.telefone = Console.ReadLine();
                        string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(nome,sobrenome,peso,altura,telefone) VALUES('{0}','{1}',{2},{3},'{4}')", x.nome, x.sobrenome, x.peso, x.altura, x.telefone);
                        command.CommandText = q;
                        command.ExecuteNonQuery();
                        pessoas.Add(x);
                        op = 0;
                    }

                    if (op == 2)
                    {
                        Console.Write("Consulta por nome(1) ou id(2)? ");
                        int op2 = int.Parse(Console.ReadLine());
                        string w = String.Format("SELECT * from pessoa");
                        command.CommandText = w;
                        MySqlDataReader reader = command.ExecuteReader();

                        if (op2 == 1)
                        {
                            string consultanome = Console.ReadLine();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetString(1) == consultanome)
                                    {
                                        Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5}",
                                            reader.GetInt32(0),
                                            reader.GetString(1),
                                        reader.GetString(2),
                                        reader.GetDouble(3),
                                        reader.GetDouble(4),
                                        reader.GetString(5));
                                    }
                                }
                            }
                            reader.Close();
                        }
                        op = 0;
                        
                    }


                    while (op != 1 && op != 2 && op != 3)
                    {
                        Console.Write("Escolha 1 , 2 ou 3: ");
                        op = int.Parse(Console.ReadLine());

                    }
                }




                Console.ReadKey();
            conn.Close();

        }
    }
}
