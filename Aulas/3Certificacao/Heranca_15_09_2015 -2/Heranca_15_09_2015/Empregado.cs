using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_15_09_2015
{
    class Empregado
    {
        public double Salario { get; set; }

        public double ValeAlimentacao()
        {
            double auxiliar = Salario * 1.08;

            if (auxiliar > 750.00)
            {
                auxiliar = 750;
            }

            return auxiliar;
        }
    }
}
