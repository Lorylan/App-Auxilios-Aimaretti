﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.Clases
{
    class PagoCliente
    {
        public String ComprobanteNro { get; set; }
        public String FechaC { get; set; }
        public String Monto { get; set; }
        public String Tipo { get; set; }
        public String Nro { get; set; }
        public String Banco { get; set; }
        public String NroCuenta { get; set; }
        public String Fecha { get; set; }
        public String Detalle { get; set; }
        public String idCliente { get; set; }
        public String idUsuario { get; set; }

        public string nroFactura { get; set; }
        public PagoCliente(String com_nro, String fc, String m, String nro, String b,String nro_c,
            String fecha, String d, String idC, String t, String nroF) {
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
            nroFactura = nroF;
        }

    }
}
