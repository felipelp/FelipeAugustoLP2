using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14_07_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro fido = new Cachorro();
            fido._tamanhoCm = 95;
            fido.SetNome("Fido");
            fido.SetPeso(42.3);

           Console.WriteLine("Nome: {0}",fido.GetNome());
            Console.WriteLine("Peso: {0}",fido.GetPeso());
            Console.WriteLine("Tamanho (m): {0}",fido._tamanhoCm);

            Console.WriteLine("Quantidade diária de ração: {0}", fido.RacaoDiariaKg());

            Console.ReadKey();


            // ----------------> ERRO <<<<<<<<<<<<<<<<<<<<<---------- \\

            // O ERRO ESTÁ NO _tamanhoCm não possuir Get e Set, isto pode gerar grandes futuros problemas.
           
        }
    }
}
