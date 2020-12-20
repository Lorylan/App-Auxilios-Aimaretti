using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.Clases
{
    class Usuario
    {
        public string Nombre { get; set; }   
        public string Contraseña { get; set; }
        public Usuario(string nom, string con) {
            Nombre = nom;
            Contraseña = con;
        }
    }
}
