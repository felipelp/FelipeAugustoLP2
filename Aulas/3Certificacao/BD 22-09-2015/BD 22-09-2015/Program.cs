using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD_22_09_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";

            MySqlConnection Conn = new MySqlConnection(strConn); 

            MySqlCommand command = new MySqlCommand();

            string nome = "";
            string cpf = "";
            string sobrenome = "";

            Console.WriteLine("Cadastro de usuários");
            Console.Write("Nome: "); nome = Console.ReadLine();
            Console.Write("Sobrenome: "); sobrenome = Console.ReadLine();
            Console.Write("CPF: "); cpf = Console.ReadLine();
            

            string adicionarnome = "INSERT INTO PESSOA (Nome) VALUES ('" +nome+ "');";
            string adicionarsobrenome = "INSERT INTO PESSOA (Sobrenome) VALUES ('" + sobrenome + "');";
            string adicionarcpf = "INSERT INTO PESSOA (CPF) VALUES ('" + cpf + "');";

            command.Connection = Conn;
            command.CommandText = adicionarnome;
            command.CommandText = adicionarcpf;
            command.CommandText = adicionarsobrenome;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();





        }
    }
}
