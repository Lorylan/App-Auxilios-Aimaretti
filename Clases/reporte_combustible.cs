using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuxiliosAimaretti.BaseDeDatos;

namespace AuxiliosAimaretti.Clases
{
    class reporte_combustible :reporte
    {
        public List<Combustible> list_combustible { get; private set; }
        public double cant_cobustible_cargado { get; private set; }
        
        public void createReporteCombustible(String desde, String hasta, String emp) {
            this.empresa = emp;
            this.fecha_inicio = desde;
            this.fecha_fin = hasta;
            CombustibleBD combustibleBD = new CombustibleBD();
            list_combustible = new List<Combustible>();
            Combustible combustible_aux;
            var list_c = combustibleBD.MostrarDesdeHasta(desde, hasta,empresa);
            string litros;
            string importe;
            String fecha;
            total_parcial = 0;
            cant_cobustible_cargado = 0;
            foreach (System.Data.DataRow rows in list_c.Rows) {
                fecha = Convert.ToString(rows[1]);
                litros = Convert.ToString(rows[2]);
                importe = Convert.ToString(rows[3]);
                combustible_aux = new Combustible(fecha,litros,importe,"");
                list_combustible.Add(combustible_aux);
            }
            try
            {
                cant_cobustible_cargado = Convert.ToDouble(combustibleBD.CalcularTotalLitros(desde,hasta,emp));
                total_parcial = Convert.ToDouble(combustibleBD.CalcularTotalDesdeHasta(desde,hasta,emp));
            }
            catch {
                total_parcial = 0;
            }
            
        }

    }
}
