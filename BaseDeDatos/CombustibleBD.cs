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
    class CombustibleBD
    {
        Conexion conexion;

        public CombustibleBD()
        {
            conexion = new Conexion();
        }

        public bool Agregar(Combustible c)
        {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Combustible VALUES ('" + c.Fecha + "', '" + c.Litros + "', '" + c.Importe + "','" + c.Usuario + "' ,'" + c.idCliente + "')");
        }
        public bool Borrar(int id)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From Combustible WHERE Id='" + id + "'");
        }
        public bool Modificar(Combustible c, int id)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE Combustible SET Fecha='" + c.Fecha + "', Litro='" + c.Litros + "', Importe='" + c.Importe + "', idCliente ='" + c.idCliente + "' WHERE Id='" + id + "'");
        }
        public DataSet MostrarInfo(string idC)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Combustible Where idCliente='" + idC + "'");
            return conexion.EjecutarSentencia(sentencia);
        }
        public string CalcularTotal(string idC)
        {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Combustible WHERE idCliente='" + idC + "'");
        }
        public string CalcularTotalDesdeHasta(string desde, string hasta, string idC)
        {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Combustible WHERE idCliente='" + idC + "' AND Fecha >= CONVERT(date,'" + desde + "') AND Fecha<= CONVERT(date,'" + hasta + "')");
        }
        public DataTable MostrarDesdeHasta(String desde, String hasta, string empresa)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Combustible Where Fecha >= CONVERT(date,'" + desde + "') AND Fecha <= CONVERT(date,'" + hasta + "') AND idCliente = '" + empresa+"'");
            DataTable datos = conexion.EjecutarSentencia(sentencia).Tables[0];
            return datos;
        }
        public string CalcularTotalLitros(string desde,string hasta, string idC) {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Litro)) FROM Combustible WHERE idCliente='" + idC + "' AND Fecha >= CONVERT(date,'" + desde + "') AND Fecha<= CONVERT(date,'" + hasta + "')");
        }

        public string CalcularSubTotal(DateTime desde, DateTime hasta)
        {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Combustible WHERE Fecha >= CONVERT(date,'" + desde + "') AND Fecha <= CONVERT(date,'" + hasta + "')");
        }

        
    }
}