using PuebaDeDiseñoAA.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuebaDeDiseñoAA.BaseDeDatos
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
            return conexion.ejecutarComandoSinRetorno("INSERT INTO Combustible VALUES ('"+ c.Fecha +"', '" +c.Litros+"', '"+ c.Importe +"','"+ c.Usuario +"' ,'"+c.idCliente+"')");
        }
        public bool Borrar(int id)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From Combustible WHERE Id='"+id+"'");
        }
        public bool Modificar(Combustible c, int id)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE Combustible SET Fecha='"+ c.Fecha+"', Litros='"+c.Litros+"', Importe='"+c.Importe+"', idCliente ='"+ c.idCliente+"' WHERE Id='"+id+"'");
        }
        public DataSet MostrarInfo(string idC)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Combustible Where idCliente='"+idC+"'");
            return conexion.EjecutarSentencia(sentencia);
        }
        public string CalcularTotal(string idC) {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Combustible WHERE idCliente='"+idC+"'");
        }
        public DataTable MostrarDesdeHasta(String desde, String hasta) {
            SqlCommand sentencia = new SqlCommand("SELECT * From Combustible Where Fecha >='"+desde+"' AND Fecha <='"+hasta+"'");
            DataTable datos = conexion.EjecutarSentencia(sentencia).Tables[0];
            return datos;
        }

        public string CalcularSubTotal(DateTime desde, DateTime hasta) {
            return conexion.EjecutarConsultaConRetorno("SELECT SUM(CONVERT(float,Importe)) FROM Combustible WHERE Fecha >='" + desde + "' AND Fecha <='" + hasta + "'");
        }

    }
}
