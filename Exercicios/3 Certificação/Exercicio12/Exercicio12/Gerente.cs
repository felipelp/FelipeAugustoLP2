using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Gerente:Funcionario
    {
        

            public string AreaAtuacao { get; set; }

          

            public override double CalculaVale()
            {
                double valeAlimentacao = Salario * (6.5 / 100);

                if (valeAlimentacao > 750)
                {
                    valeAlimentacao = 750;
                }

                return valeAlimentacao;
            
        }
    }
}
