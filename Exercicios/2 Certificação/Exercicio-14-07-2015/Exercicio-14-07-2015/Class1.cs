using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14_07_2015
{
    class Cachorro
    {
      public  int _tamanhoCm;
      public string _nome;
      public double _peso;
  

      public void SetNome(string nome)
    {
        _nome = nome;   
    }

        public string GetNome()
      {
          return _nome;
      }
      public void SetPeso(double peso)
      {
          _peso = peso;

      }
        public double GetPeso()
      {
          return _peso;
      }

        public double RacaoDiariaKg()
        {
            return (_peso / ((_tamanhoCm / 100) * (_tamanhoCm / 100))) / 10;
        }
    }
}
