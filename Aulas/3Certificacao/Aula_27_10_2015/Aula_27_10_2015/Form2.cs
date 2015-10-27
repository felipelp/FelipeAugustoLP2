using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_27_10_2015
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        livro x = new livro();
       
        private void busca_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            string w = String.Format("SELECT Id,Titulo,Isbn,Genero,Preco,Autor from pessoa WHERE Isbn = {0}",bisbn.Text);
            command.CommandText = w;
 
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    x.id = reader.GetInt32(0);
                    x.titulo = reader.GetString(1);
                    x.isbn = reader.GetString(2);
                    x.genero = reader.GetString(3);
                    x.preco = Convert.ToDouble(reader.GetDouble(4));
                    x.autor = reader.GetString(5);
                }
            }
            reader.Close();
            conn.Close();


     
  

        }

        private void bisbn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
