using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuxiliosAimaretti.Clases;
using AuxiliosAimaretti.BaseDeDatos;

namespace AuxiliosAimaretti.Clases
{
    class reporte_liquidacion : reporte
    {
        public int cant_servicios { get; set; }
        public double total_servicios { get; set; }
        public double cant_combustible { get; set; }
        public double total_combustible { get; set; }

        public void createReporteLiquidacion(String desde, String hasta, String emp)
        {
            this.empresa = emp;
            this.fecha_inicio = desde;
            this.fecha_fin = hasta;

            ServicioBD servicioBD = new ServicioBD();
            var list_s = servicioBD.MostrarDesdeHasta(desde, hasta,empresa);
            this.total_servicios = Convert.ToDouble(servicioBD.CalcularTotalDesdeHasta(desde,hasta,emp));
            this.cant_servicios = 0;
            foreach (System.Data.DataRow rows in list_s.Rows)
            { 
                cant_servicios++;
            }
            this.cant_combustible = 0;
            this.total_combustible = 0;
            CombustibleBD combustibleBD = new CombustibleBD();
            var list_c = combustibleBD.MostrarDesdeHasta(desde, hasta,empresa);
            foreach (System.Data.DataRow rows in list_c.Rows)
            {

                cant_combustible += Convert.ToDouble(rows[2]);
            }
            total_combustible = Convert.ToDouble(combustibleBD.CalcularTotalDesdeHasta(desde,hasta,emp));
            this.total_parcial = total_servicios - total_combustible;

        }
    }
}
