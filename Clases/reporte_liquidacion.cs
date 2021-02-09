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
            try
            {
                this.total_servicios = Convert.ToDouble(servicioBD.CalcularTotalDesdeHasta(desde, hasta, emp));
            }
            catch {
                this.total_servicios = 0;
            }
            this.cant_servicios = 0;
            cant_servicios = list_s.Rows.Count;
            this.cant_combustible = 0;
            this.total_combustible = 0;
            CombustibleBD combustibleBD = new CombustibleBD();
            var list_c = combustibleBD.MostrarDesdeHasta(desde, hasta,empresa);
            try
            {
                cant_combustible = Convert.ToDouble(combustibleBD.CalcularTotalLitros(desde, hasta, empresa));
            }
            catch {
                cant_combustible = 0;
            }
            
            try
            {
                total_combustible = Convert.ToDouble(combustibleBD.CalcularTotalDesdeHasta(desde, hasta, emp));
            }
            catch {
                total_combustible = 0;
            }
            this.total_parcial = total_servicios - total_combustible;

        }
    }
}
