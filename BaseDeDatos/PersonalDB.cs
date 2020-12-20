using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AuxiliosAimaretti.Clases;
using System.ComponentModel.Design.Data;
using System.Windows;

namespace AuxiliosAimaretti.BaseDeDatos
{
    class PersonalDB
    {
        Conexion conexion;
        
        public PersonalDB() {
            conexion = new Conexion();
        }

        public bool Agregar(Personal p) {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Personal VALUES('"+p.Nombre+"', '"+p.Apellido+"', '"+p.Documento+"','"+p.Telefono+"','"+p.Email+"', '"+p.CategoriaRegistro+"')");     
        }
        public bool Borrar(Personal p) {
            return conexion.ejecutarComandoSinRetorno("DELETE From Personal WHERE Documento='"+p.Documento+"'"); 
        }
        public bool Modificar(Personal p, string doc) {
            return conexion.ejecutarComandoSinRetorno("UPDATE Personal SET Nombre='"+p.Nombre+"', Apellido='"+p.Apellido +"', Documento='"+p.Documento +"', Telefono='"+p.Telefono+"', Email='"+p.Email+"', CategoriaRegistro='"+p.CategoriaRegistro +"' WHERE Documento='"+doc+"'");
        }
        public DataSet MostrarInfo() {
            SqlCommand sentencia = new SqlCommand("SELECT * From Personal");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
