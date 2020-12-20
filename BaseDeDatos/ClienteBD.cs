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
    class ClienteBD
    {
        Conexion conexion;
        public ClienteBD() {
            conexion = new Conexion();
        }
        public bool Agregar(Cliente c) {
           return conexion.ejecutarComandoSinRetorno("INSERT INTO Cliente VALUES ('"+ c.NombreEmpresa +"','"+ c.Cuit+"','"+
                c.Email +"','"+c.Telefono +"','"+ c.CuentaBancaria+"','"+ c.CBU +"','"+ c.Domicilio +"','"+ c.Observaciones + "')");
        }
        public bool Borrar(Cliente c)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From Cliente WHERE NombreEmpresa='"+c.NombreEmpresa+"'");
        }
        public bool Modificar(Cliente c, string nom)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE Cliente SET NombreEmpresa='"+ c.NombreEmpresa +"', Cuit='"+ c.Cuit+ "', Domicilio='"+ c.Domicilio +"', Telefono='"+ c.Telefono +"', Email='"+ c.Email +"', CuentaBancaria='"+ c.CuentaBancaria +"', CBU='"+c.CBU+"' , Observaciones='"+ c.Observaciones+"' WHERE NombreEmpresa='"+ nom +"'");
        }
        public DataSet MostrarInfo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Cliente");
            return conexion.EjecutarSentencia(sentencia);
        }
        public DataSet Mostrar_info_de(String nombre_empresa)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From Cliente WHERE NombreEmpresa='"+nombre_empresa+"'");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
