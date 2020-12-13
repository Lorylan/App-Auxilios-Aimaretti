using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuebaDeDiseñoAA.BaseDeDatos;

namespace PuebaDeDiseñoAA.Clases
{
    class reporte_servicios: reporte
    {
        public List<Servicio> list_servicio { get; private set; }
        public double cant_servicios { get; private set; }
        public void createReporteServicio(String desde, String hasta, String emp)
        {
            this.empresa = emp;
            this.fecha_inicio = desde;
            this.fecha_fin = hasta;
            ServicioBD servicioBD = new ServicioBD();
            list_servicio = new List<Servicio>();
            Servicio servicio_aux;
            var list_c = servicioBD.MostrarDesdeHasta(desde, hasta);
            total_parcial = 0;
            cant_servicios = 0;
            String fecha;
            String codigo;
            String tipo;
            String desde_serv;
            String hasta_serv;
            String km;
            String importe;

            foreach (System.Data.DataRow rows in list_c.Rows)
            {
                fecha = Convert.ToString(rows[1]);
                codigo = Convert.ToString(rows[2]);
                tipo = Convert.ToString(rows[3]);
                desde_serv = Convert.ToString(rows[9]);
                hasta_serv = Convert.ToString(rows[10]);
                km = Convert.ToString(rows[12]);
                importe = Convert.ToString(rows[13]);
                servicio_aux = new Servicio(fecha,codigo,desde,hasta,"","","","","","",km,"","",tipo,importe);
                list_servicio.Add(servicio_aux);
                total_parcial += Convert.ToDouble(importe);
            }
            cant_servicios = list_c.Rows.Count;
        }
    }
}
