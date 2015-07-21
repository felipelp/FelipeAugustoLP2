using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09_Funcionarios
{
    public class Funcionario
    {
      public DateTime dn;
      public double s;
      public int cpf;
      public double sn;
      public DateTime da;
      public string nome;


      public double Calcula()
      {
         if (da.Year >= 2014)
          {
              sn = s + 423.45;
          }
          else if (da.Year >= 2000 && da.Year <= 2010)
          {
              sn = s + (s * 16.4 / 100);
          }

          else if (da.Year < 2000)
          {
              sn = s + (s * 22.6 / 100);
          }
          else if (da.Year >= 2010 && da.Year <= 2013)
          {
              sn = s + (s * 9.84 / 100);
          }

          return sn;
      }
    
    
    
    
    }

   
}
