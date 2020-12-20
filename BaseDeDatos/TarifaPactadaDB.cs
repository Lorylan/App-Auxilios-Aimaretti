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
    class TarifaPactadaDB
    {
        Conexion conexion;
        public TarifaPactadaDB()

        {
            conexion = new Conexion();
        }
        public bool Agregar(TarifaPactada tp)
        {
            return conexion.ejecutarComandoSinRetorno("INSERT INTO TarifaPactada VALUES('" +tp.idTipo + "', '" + tp.importe + "', '" + tp.idCliente +"')");
        }
        public bool Borrar(TarifaPactada tp)
        {
            return conexion.ejecutarComandoSinRetorno("DELETE From TarifaPactada WHERE idCliente=" +tp.idCliente+" AND idTipo="+tp.idTipo);
        }
        public bool BorrarDe(string idC) {
            return conexion.ejecutarComandoSinRetorno("DELETE From TarifaPactada WHERE idCliente='"+idC+"'");
        }
        public bool Modificar(TarifaPactada tp, string cli, string tip)
        {
            return conexion.ejecutarComandoSinRetorno("UPDATE TarifaPactada SET idCliente='"+ tp.idCliente +"', idTipo='"+ tp.idTipo +"', Importe='"+tp.importe +"' WHERE  idCliente='"+cli +"' AND idTipo='"+tip+"'");
        }
        public DataSet MostrarInfoDe(string idCliente )
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From TarifaPactada WHERE idCLiente='"+idCliente+"'");
            return conexion.EjecutarSentencia(sentencia);
        }
        public bool ExisteTarifaDe(string idCliente, String tipo)
        {
            SqlCommand sentencia = new SqlCommand("SELECT * From TarifaPactada WHERE idCLiente='" + idCliente + "' AND idTipo='" + tipo + "'");
            if (conexion.EjecutarSentencia(sentencia).Tables[0].Rows.Count > 0) {
                return true;
            }
            return false;
            
        }
        public string BuscarTarifaDe(String cliente, String tipo) {
            
            return conexion.EjecutarConsultaConRetorno("SELECT Importe From TarifaPactada WHERE idCLiente='" + cliente + "' AND idTipo='" + tipo + "'");
        }
    }
}
