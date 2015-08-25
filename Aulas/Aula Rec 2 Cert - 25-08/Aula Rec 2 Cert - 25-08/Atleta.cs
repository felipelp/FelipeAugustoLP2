using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Rec_2_Cert___25_08
{
    class Atleta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int TempoCs { get; set; }

        public string TempoFormat
        {
            get
            {
                return String.Format("{0}:{1}:{2}", TempoCs / 6000, (TempoCs % 6000) / 100, (TempoCs % 6000) % 100);
            }
        }
    }
}
