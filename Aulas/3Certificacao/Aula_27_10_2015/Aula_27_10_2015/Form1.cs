using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_27_10_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 consulta = new Form2();
            consulta.ShowDialog();
            
        }

        private void busca_Click(object sender, EventArgs e)
        {
            
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
