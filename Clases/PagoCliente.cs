using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuebaDeDiseñoAA.Clases
{
    class PagoCliente
    {
        public String ComprobanteNro { get; set; }
        public DateTime FechaC { get; set; }
        public String Monto { get; set; }
        public String Tipo { get; set; }
        public String Nro { get; set; }
        public String Banco { get; set; }
        public String NroCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public String Detalle { get; set; }
        public String idCliente { get; set; }
        public String idUsuario { get; set; }


        public PagoCliente(String com_nro, DateTime fc, String m, String nro, String b,String nro_c,
            DateTime fecha, String d, String idC, String t) {
            idUsuario = Program.nombreUsuario;
            idCliente = idC;
            Detalle = d;
            Fecha = fecha;
            NroCuenta = nro_c;
            Banco = b;
            Nro = nro;
            Monto = m;
            FechaC = fc;
            ComprobanteNro = com_nro;
            Tipo = t;
        }

    }
}
