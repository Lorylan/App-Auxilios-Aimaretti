using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.Clases
{
    class TarifaPactada
    {
        public string idCliente { get; set; }
        public string idTipo { get; set; }
        public string importe { get; set; }
        public TarifaPactada(string idC, string idT, string imp) {
            idCliente = idC;
            idTipo = idT;
            importe = imp;
        }
    }
}
