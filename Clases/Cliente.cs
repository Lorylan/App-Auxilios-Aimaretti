using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PuebaDeDiseñoAA.Clases
{
    class Cliente
    {
        public string NombreEmpresa { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CuentaBancaria { get; set; }
        public string CBU { get; set; }
        public string Observaciones { get; set; }

        public Cliente(string nom, string cuit,string dom, string tel, string email, string cuenta, string cbu,string obs) {
            NombreEmpresa = nom;
            Cuit = cuit;
            Domicilio = dom;
            Telefono = tel;
            Email = email;
            CuentaBancaria = cuenta;
            CBU = cbu;
            Observaciones = obs;
        }
    }
}
