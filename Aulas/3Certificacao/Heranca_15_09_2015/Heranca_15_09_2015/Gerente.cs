using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_15_09_2015
{
    class Gerente : Funcionario
    {
        public string AreaGerenciada { get; set; }
        public double Adicional { get; set; }

        public double STotal()
        {
            return Salario + Adicional;
        }
    }
}
