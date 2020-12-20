using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxiliosAimaretti.Clases
{
    class Combustible
    {
        public String Fecha { get; set; }
        public String Litros { get; set; }
        public String Importe { get; set; }
        public String idCliente { get; set; }
        public String Usuario { get; set; }
  
        public int id;
        public Combustible(string fecha, string l, string im, string idC) {
            Fecha = fecha;
            Importe = im;
            Litros = l;
            idCliente = idC;
            Usuario = Program.nombreUsuario;
        }
        public Combustible(string fecha, string l, string im, string idC, int i)
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
