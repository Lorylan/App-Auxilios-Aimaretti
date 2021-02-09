using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuxiliosAimaretti.BaseDeDatos;

namespace AuxiliosAimaretti.Clases
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
            var list_s = servicioBD.MostrarDesdeHasta(desde, hasta,empresa);
            total_parcial = 0.00;
            cant_servicios = 0;
            String fecha;
            String codigo;
            String tipo;
            String desde_serv;
            String hasta_serv;
            String km;
            String importe;

            foreach (System.Data.DataRow rows in list_s.Rows)
            {
                fecha = Convert.ToString(rows[1]);
                codigo = Convert.ToString(rows[2]);
                tipo = Convert.ToString(rows[3]);
                desde_serv = Convert.ToString(rows[9]);
                hasta_serv = Convert.ToString(rows[10]);
                km = Convert.ToString(rows[11]);
                importe = Convert.ToString(rows[13]);
                servicio_aux = new Servicio(fecha,codigo,desde_serv,hasta_serv,"","","","","","",km,"","",tipo,importe);
                list_servicio.Add(servicio_aux);
                
            }
            cant_servicios = list_s.Rows.Count;
            try
            {
                total_parcial = Convert.ToDouble(servicioBD.CalcularTotalDesdeHasta(desde, hasta, emp));
            }
            catch {
                total_parcial = 0;
            }
            
        }
    }
}
