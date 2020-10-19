using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuebaDeDiseñoAA.Clases
{
    class Personal
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CategoriaRegistro { get; set; }

        public Personal(string doc, string nom, string ape, string tel, string em, string cate) {
            Documento = doc;
            Nombre = nom;
            Apellido = ape;
            Telefono = tel;
            Email = em;
            CategoriaRegistro = cate;
        }
    }
}
