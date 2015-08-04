using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_10_Carros
{
    public partial class Form1 : Form
    {
        List<string> carro = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Carro x = new Carro();


            try
            {
                x.SetModelo(t_modelo.Text);
                x.SetPlaca(t_placa.Text);
                x.SetMarca(t_marca.Text);
                x.SetAno(int.Parse(t_ano.Text));
                x.SetKilometragem(double.Parse(t_kilometragem.Text));
                x.SetCapacidade(double.Parse(t_capacidade.Text));
                x.SetPotencia(double.Parse(t_potencia.Text));
                carro.Add(x.GetModelo());
                carro.Add(x.GetPlaca());
                carro.Add(x.GetMarca());
                carro.Add(x.GetAno().ToString());
                carro.Add(x.GetKilometragem().ToString());
                carro.Add(x.GetCapacidade().ToString());
                carro.Add(x.GetPotencia().ToString());

                int cadastros = carro.Count / 7;
                t_cadastros.Text = Convert.ToString(cadastros);
            }
            catch
            {
                MessageBox.Show("Há campos inválidos, verifique novamente", "Erro");
            }
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {

            bool cb = true;
            int n = 1;

            while (cb == true && (1 + (7 * (n - 1))) < carro.Count)
                {
                    if (carro[1 + (7 * (n - 1))] == t_busca.Text)
                    {
                        cb = false;
                        MessageBox.Show("Carro encontrado com a placa: " + t_busca.Text + " encontrado!" + 
                            "\r\nModelo: " + carro[0 + (7 * (n - 1))] 
                            + "\r\nPlaca: " + carro[1 + (7 * (n - 1))] 
                            + "\r\nMarca: " + carro[2 + (7 * (n - 1))] 
                            + "\r\nAno: " + carro[3 + (7 * (n - 1))] 
                            + "\r\nKilometragem: " + carro[4 + (7 * (n - 1))] 
                            + "\r\nCapacidade do tanque: "  + carro[5 + (7 * (n - 1))] 
                            + "\r\nPotência: " + carro[6 + (7 * (n - 1))]);
                    }

                    else
                    {
                        MessageBox.Show("Nenhum carro foi encontrado!", "Procura por placa");
                        n += 7;
                    }
                }
                
            }
        }
    }

