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

namespace Aula06_10_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        List<Pessoas> pessoa = new List<Pessoas>();
        

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Pessoas x = new Pessoas();
            x.nome = tb_nome.Text;
            x.sobrenome = tb_sobrenome.Text;
            x.presente1 = tb_presente1.Text;
            x.presente2 = tb_presente2.Text;
            x.presente3 = tb_presente3.Text;
       
            pessoa.Add(x);

           
            
        }

        private void bt_status_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No momento foram encontrados: " + pessoa.Count + " registros.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=test;Uid=root;Pwd=");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            foreach (var item in pessoa)
            {
                string q = string.Format("INSERT INTO AMIGOOCULTO(nome,sobrenome,presente1,presente2,presente3) VALUES('{0}','{1}','{2}','{3}','{4}')", item.nome, item.sobrenome, item.presente1, item.presente2, item.presente3);
                command.CommandText = q;
                command.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
