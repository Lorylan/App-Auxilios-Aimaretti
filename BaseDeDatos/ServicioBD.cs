using AuxiliosAimaretti.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliosAimaretti.BaseDeDatos
{
    class ServicioBD
    {
        Conexion conexion;
        public ServicioBD()
        {
            conexion = new Conexion();
        }
        public bool Agregar(Servicio s)
        {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Servicio VALUES ('"+s.Fecha+"', '"+s.Codigo+"','"+
                 s.idTipo+"', '"+s.Vehiculo+"','"+s.Patente+"','"+s.Color+"','"+s.Desperfecto+"','"+s.Movil+"', '"+s.Desde+"', '"+s.Hasta+"', '"+
                 s.Km+"', '"+s.MontoCobrado+"', '"+s.Importe+"', '"+s.Observaciones+"', '"+s.Usuario+ "', '" + s.idCliente + "' )");
        }
        public bool Borrar(int id)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From Servicio WHERE id='"+id+"'");
        }
        public bool Modificar(Servicio s, int id)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE Servicio SET Fecha='" + s.Fecha + "', Codigo='" + s.Codigo + "', " +
                "idTipo= '" + s.idTipo + "', Vehiculo='" + s.Vehiculo + "', Patente='" + s.Patente + "', Color='" + s.Color + "', Desperfecto='" + s.Desperfecto + "'," +
                " Movil='" + s.Movil + "', Desde='" + s.Desde + "', Hasta='" + s.Hasta + "', Km='" + s.Km + "', MontoCobrado='" + s.MontoCobrado+"', Importe='"+s.Importe+"', " +
                " Observaciones='"+s.Observaciones+"', idCliente='"+s.idCliente+"' WHERE id='"+id+"'"); 
        }
        public DataSet MostrarInfo(String empresa)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Servicio WHERE idCliente='"+empresa+"'");
            return conexion.EjecutarSentencia(sentencia);
        }

        public string CalcularTotal(string idC)
        {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Servicio WHERE idCliente='" + idC + "'");
        }

        public DataTable MostrarDesdeHasta(String desde, String hasta, string empresa)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Servicio Where Fecha >='" + desde + "' AND Fecha <='" + hasta + "' AND idCliente='"+empresa+"'");
            DataTable datos = conexion.EjecutarSentencia(sentencia).Tables[0];
            return datos;
        }
    }
}
