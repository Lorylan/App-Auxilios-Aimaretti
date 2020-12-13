using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PuebaDeDiseñoAA.Clases;

namespace PuebaDeDiseñoAA.BaseDeDatos
{
    class PagoClienteBD
    {
        Conexion conexion;

        public PagoClienteBD()
        {
            conexion = new Conexion();
        }

        public bool Agregar(PagoCliente pc)
        {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO PagoCliente VALUES('" + pc.ComprobanteNro 
                + "', '" + pc.FechaC + "', '" + pc.Monto + "','" + pc.Nro + "', '" + pc.Banco 
                + "' , '" + pc.NroCuenta + "' , '" + pc.Fecha + "' , '" + pc.Detalle + "' , '" + pc.idCliente
                + "', '" + pc.idUsuario + "' , '" + pc.Tipo+ "')" );
        }
        public bool Borrar(String comprobante)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From PagoCliente WHERE ComprobanteNro='" 
                + comprobante + "'");
        }
        public bool Modificar(PagoCliente pc, string comprobante)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE PagoCliente SET FechaC='" + pc.FechaC 
                + "', Monto='" + pc.Monto + "', Nro='" + pc.Nro + "', Banco='" + pc.Banco 
                + "', NroCuenta='" + pc.NroCuenta + "', Fecha='"+pc.Fecha+"', Detalle='"+pc.Detalle
                +"' WHERE  ComprobanteNro='" + comprobante + "'");
        }
        public DataSet MostrarInfo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From PagoCliente");
            return conexion.EjecutarSentencia(sentencia);
        }
        public DataSet ObtenerInfoDe(String fecha)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From PagoCliente WHERE Fecha='"+fecha+"'");
            DataSet data = conexion.EjecutarSentencia(sentencia);
            return data;
        }
        public DataSet ObtenerInfoDee(String fecha, String fecha2)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From PagoCliente WHERE Fecha='"+fecha +"' OR Fecha='"+fecha2+"'");
            DataSet data = conexion.EjecutarSentencia(sentencia);
            return data;
        }
    }
}
