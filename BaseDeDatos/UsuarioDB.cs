using AuxiliosAimaretti.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.BaseDeDatos
{
    class UsuarioDB
    {
        Conexion conexion;
        public UsuarioDB()
        {
            conexion = new Conexion();
        }
        public bool Agregar(Usuario u)
        {
            
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Usuario VALUES('" + u.Nombre + "', '" + Encriptador.encriptar(u.Contraseña)+ "')");
        }
        public bool Borrar(Usuario u)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From Usuario WHERE Nombre=" + u.Nombre);
        }
        public bool ModificarNombre(string nomActual, string nom)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE Usuario SET Nombre='" +nom+ "' WHERE Nombre ='"+nomActual+"'");
        }
        public bool ModificarContraseña(string con, string nom) {
            return conexion.ejecutarComandoSinRetorno("UPDATE Usuario SET Contraseña='"+Encriptador.encriptar(con)+ "' WHERE Nombre ='" +nom+"'");
        }
        public bool Existe(Usuario u)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Usuario WHERE Nombre='" + u.Nombre + "' AND Contraseña='" + Encriptador.encriptar(u.Contraseña) + "'");
            DataSet resu = conexion.EjecutarSentencia(sentencia);
            if (resu.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public bool nombreRepetido(string nombre) {
            SqlCommand sentencia = new SqlCommand("SELECT * From Usuario WHERE Nombre='"+nombre+"'");
            DataSet resu = conexion.EjecutarSentencia(sentencia);
            if (resu.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
