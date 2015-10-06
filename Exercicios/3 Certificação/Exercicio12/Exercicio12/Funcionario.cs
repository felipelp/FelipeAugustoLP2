using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public double Vale { get; set; }



        public virtual double CalculaVale()
        {
            double vale_alimentacao = Salario * 0.08;

            if (vale_alimentacao > 750)
            {
                vale_alimentacao = 750;
            }

            return vale_alimentacao;
        }
    }
}
