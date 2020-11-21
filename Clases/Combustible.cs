using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuebaDeDiseñoAA.Clases
{
    class Combustible
    {
        public DateTime Fecha { get; set; }
        public string Litros { get; set; }
        public string Importe { get; set; }
        public string idCliente { get; set; }
        public string Usuario { get; set; }
  
        public int id;
        public Combustible(DateTime fecha, string l, string im, string idC) {
            Fecha = fecha;
            Importe = im;
            Litros = l;
            idCliente = idC;
            Usuario = Program.nombreUsuario;
        }
        public Combustible(DateTime fecha, string l, string im, string idC, int i)
        {
            Fecha = fecha;
            Importe = im;
            Litros = l;
            idCliente = idC;
            Usuario = Program.nombreUsuario;
            id = i;
        }
    }
}
