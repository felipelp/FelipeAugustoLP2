using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10_Carros
{
    class Carro
    {
        public string _Modelo;
        public string _Marca { get; set; }
        public string _Placa { get; set; }
        public int _Ano { get; set; }
        public double _Kilometragem { get; set; }
        public double _Potencia { get; set; }
        public double _Capacidade { get; set; }


        public void SetModelo(string modelo)
        {
            _Modelo = modelo;
        }

        public string GetModelo()
        {
            return _Modelo;
        }
        public void SetPlaca(string placa)
        {
            _Placa = placa;
        }

        public string GetPlaca()
        {
            return _Placa;
        }

        public void SetMarca(string marca)
        {
            _Marca = marca;
        }

        public string GetMarca()
        {
            return _Marca;
        }

        public void SetAno(int ano)
        {
            _Ano = ano;
        }

        public int GetAno()
        {
            return _Ano;
        }

        public void SetKilometragem(double kilometragem)
        {
            _Kilometragem = kilometragem;
        }

        public double GetKilometragem()
        {
            return _Kilometragem;
        }

        public void SetCapacidade(double capacidade)
        {
            _Capacidade = capacidade;
        }

        public double GetCapacidade()
        {
            return _Capacidade;
        }

        public void SetPotencia(double potencia)
        {
            _Potencia = potencia;
        }

        public double GetPotencia()
        {
            return _Potencia;
        }
    }
}
