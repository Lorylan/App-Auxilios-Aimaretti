using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.BaseDeDatos
{
    class TipoBD
    {
        Conexion conexion;

        public TipoBD()
        {
            conexion = new Conexion();
        }

        public bool Agregar(String nombre)
        {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Tipo VALUES ('"+nombre+"')");
        }

        public DataSet ObtenerTipos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Tipo");
            return conexion.EjecutarSentencia(sentencia);
        }
       
      
    }
}
