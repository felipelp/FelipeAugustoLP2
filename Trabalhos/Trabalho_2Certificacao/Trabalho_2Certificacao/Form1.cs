using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Trabalho_2Certificacao
{
    public partial class Form1 : Form
    {

        List<Carro> carros = new List<Carro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void b_cadastrar_Click(object sender, EventArgs e)
        {
            if (t_capacidade.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo de capacidade");
            }
            if (t_modelo.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo de modelo");
            }
            if (t_marca.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo de marca");
            }
            if (t_placa.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo de placa");
            }
            

            else
            {
                try
                {
                    int capacidade = int.Parse(t_capacidade.Text);
                    if (capacidade <= 0)
                    {
                        MessageBox.Show("O campo capacidade deve ser maior que 0");
                    }
                }
                catch
                {
                    MessageBox.Show("O campo capacidade tem de ser um número inteiro");
                }
            }


            Carro x = new Carro();

            try
            {
                int capacidade = int.Parse(t_capacidade.Text);
                if (capacidade <= 0)
                {
                    MessageBox.Show("O campo capacidade deve ser maior que 0");
                }
                else
                {
                    x._Capacidade = capacidade;
                    x._ID = carros.Count + 1;
                    x._Modelo = t_modelo.Text;
                    x._Marca = t_marca.Text;
                    x._Placa = t_placa.Text;
                    x._CapacidadeI = capacidade;

                    carros.Add(x);

                    t_modelo.Clear();
                    t_marca.Clear();
                    t_capacidade.Clear();
                    t_placa.Clear();
                }
            }
            catch
            {
                MessageBox.Show("O campo capacidade tem de ser um número inteiro");
            }      
        }

       
        private void b_entrar_Click(object sender, EventArgs e)
        {

            int ecpid = int.Parse(t_ecpid.Text);

            try
            {
               

                if (ecpid > carros.Count || ecpid == 0)
                {
                    MessageBox.Show("ID inserido inválido");
                }

                foreach (var item in carros)
                {
                    int id = int.Parse(t_ecpid.Text);
                    string modelo = item._Modelo;
                    string marca = item._Marca;
                    string placa = item._Placa;


                    if (id == item._ID)
                    {
                        if (item._Capacidade > 0)
                        {
                            item._Capacidade -= 1;
                            int capacidade = item._Capacidade;

                            int capacidade2 = item._Capacidade;
                        }
                        else
                        {
                            MessageBox.Show("Esse veículo está lotado!", "Veículo lotado");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ID deve ser um valor válido");
            }


            int soma = 0;

            foreach (var algo in carros)
            {
                ArrayList infocapacidades = new ArrayList();
                int capacidade3 = algo._Capacidade;
                infocapacidades.Add(capacidade3);

                for (int i = 0; i < infocapacidades.Count; i++)
                {
                    soma += Convert.ToInt32(infocapacidades[i]);
                  
                }
            }

           

            if (soma == 0 || ecpid == -1)
            {

                int passageiros_total = 0;

                    foreach (var car in carros)
	                {

                        int passageiros = car._CapacidadeI - car._Capacidade;
                        ArrayList passageirostotal = new ArrayList();
                        passageirostotal.Add(passageiros);

                       

                        for (int i = 0; i < passageirostotal.Count; i++)
                        {
                            passageiros_total += Convert.ToInt32(passageirostotal[i]);
                        }

                        if (car._Capacidade > 0)
                        {
                            MessageBox.Show("Carro " + car._ID + ": " + car._Modelo + " - " + car._Marca + " (" + car._Placa + ") \r\n" +
                                "Passageiros: " + passageiros + " \r\n" + "Vagas restantes: " + car._Capacidade);
                        }
                        else 
                        {
                         MessageBox.Show("Carro " + car._ID + ": " + car._Modelo + " - " + car._Marca + " (" + car._Placa + ") \r\n" +
                         "Passageiros: " + passageiros + " \r\n" + "Carro lotado");
                        }

                        

                    }

                    MessageBox.Show("Total de pessoas na viagem: " + passageiros_total);
            }
            
            
                
           
        }
    }
}
