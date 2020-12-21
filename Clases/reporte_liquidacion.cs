using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.Clases
{
    class reporte_liquidacion: reporte
    {
        public int cant_servicios { get; set; }
        public double tota_servicios { get; set; }
        public int cant_combustible { get; set; }
        public double total_combustible { get; set; }

    }
}
