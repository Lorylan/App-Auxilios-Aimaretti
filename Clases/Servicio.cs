using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PuebaDeDiseñoAA.Clases
{
    class Servicio
    {
        public String Fecha { get; set; }
        public string Codigo { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string MontoCobrado { get; set; }
        public string Observaciones { get; set; }
        public string Vehiculo { get; set; }
        public string Patente { get; set; }
        public string Color { get; set; }
        public string Desperfecto { get; set; }
        public string Km { get; set; }
        public  string Movil { get; set; }
        public string Importe { get; set; }
        public string idCliente { get; set; }
        public string idTipo { get; set; }
        public string Usuario { get; set; }

        public Servicio (String f, string cod, string desde, string hasta, string monto, string obs,string veh,string pate,
            string col, string des, string km, string movil,string idC, string idT, string importe){
            Fecha = f;
            Codigo = cod;
            Desde = desde;
            Hasta = hasta;
            MontoCobrado = monto;
            Observaciones = obs;
            Vehiculo = veh;
            Patente = pate;
            Color = col;
            Desperfecto = des;
            Km = km;
            Movil = movil;
            idCliente = idC;
            idTipo = idT;
            Usuario = Program.nombreUsuario;
            Importe = importe;
        }
    }
}
