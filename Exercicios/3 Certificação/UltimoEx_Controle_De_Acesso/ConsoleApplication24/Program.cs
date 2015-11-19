using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria a classe identificação do usuário
            user usuario = new user();
            // Verifica se o login está feito
            bool loginsuccess = false;
            

                while(loginsuccess == false) //Caso o login não esteja feito...
                {
                string login, senha; // O usuário digitará um login e uma senha.
                Console.Write("Login: "); login = Console.ReadLine();
                Console.Write("Senha: "); senha = Console.ReadLine();
                MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=lp");
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                conn.Open();

                string w = String.Format("SELECT * from usuario WHERE Login = '{0}' AND Senha = '{1}'", login, senha); // Consulta o usuário
                command.CommandText = w;
                MySqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read()) // Se há usuário...
                    {
                        DateTime date = DateTime.Now; // Pega a data de agora
                        string dates = Convert.ToString(date); // Transforma a data atual em string
                        usuario.id = reader.GetInt32(0); // Coloca o id do usuário na classe
                        usuario.nome = reader.GetString(1); // Coloca o nome do usuário na classe
                        usuario.UltimoAcesso = dates; // Coloca a data e hora atual do login de agora do usuário na classe
                        loginsuccess = true; // Confirma que houve o login
                    } 
                }


                else
                {
                    Console.WriteLine("Login ou senha incorretos, tente novamente.");
                    loginsuccess = false; // Confirma que não houve login
                }


                if (loginsuccess == true) // Se houver login
                {
                    reader.Close();
                    Console.WriteLine("Seja bem vind@, {0}. Você efetuou login com sucesso em {1}.", usuario.nome,usuario.UltimoAcesso);
                    string u = String.Format("UPDATE usuario SET DataUa = '{0}' WHERE Id = {1}", usuario.UltimoAcesso, usuario.id); // Atualiza a data e hora do último login do usuário no banco
                    command.CommandText = u;
                    command.ExecuteNonQuery();

                    string op = ""; //Para usuário definir uma operação

                    while (op != "sair")
                    {
                        Console.WriteLine("{0} caso deseje sair, digite sair", usuario.nome);
                        op = Console.ReadLine();
                    }

                    if (op == "sair")
                    {
                        Console.WriteLine("Você fez logout, até a próxima, {0}", usuario.nome);
                        loginsuccess = false; // Logout
                    }
                }
            }


            Console.ReadKey();

        }
    }
}
