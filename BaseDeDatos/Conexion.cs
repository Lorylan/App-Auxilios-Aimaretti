using PuebaDeDiseñoAA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Data;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PuebaDeDiseñoAA.BaseDeDatos
{
    class Conexion
    {
        private string cadenaConexion = "server=localhost\\SQLEXPRESS; database=ProyectoAA; integrated security=true";
        SqlConnection conexion;

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection();
            this.conexion.ConnectionString = cadenaConexion;
            return this.conexion;
        }
        /*Metodo Insertar, Delete, Update*/
        public bool ejecutarComandoSinRetorno(string strComando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = strComando;
                comando.Connection = EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*Metodo Select (retorno de datos)*/
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;
                comando.Connection = EstablecerConexion();
                adaptador.SelectCommand = comando;
                conexion.Open();
                adaptador.Fill(ds);
                return ds;
            }
            catch
            {
                return ds;
            }
        }
        public string EjecutarConsultaConRetorno(string strComando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = strComando;
                comando.Connection = EstablecerConexion();
                conexion.Open();
                string aux = comando.ExecuteScalar().ToString();
                conexion.Close();
                return aux;
            }
            catch
            {
                return null;
            }
        }
    }
}
