using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuebaDeDiseñoAA.BaseDeDatos;

namespace PuebaDeDiseñoAA.Clases
{
    class reporte_combustible
    {
        public DateTime fecha_inicio { get; private set; }
        public DateTime fecha_fin { get; private set; }
        public List<Combustible> list_combustible { get; private set; }
        public double total_parcial { get; private set; }
        public string empresa { get; private set; }
        public void createReporteCombustible(DateTime desde, DateTime hasta, string empresa) {
            this.empresa = empresa;
            CombustibleBD combustibleBD = new CombustibleBD();
            Combustible combustible_aux;
            var list_c = combustibleBD.MostrarDesdeHasta(desde, hasta);
            DateTime fecha;
            string litros;
            string importe;
            total_parcial = 0;
            foreach (System.Data.DataRow rows in list_c.Rows) {
                fecha = Convert.ToDateTime(rows[1]);
                litros = Convert.ToString(rows[2]);
                importe = Convert.ToString(rows[3]);
                combustible_aux = new Combustible(fecha,litros,importe,"");
                list_combustible.Add(combustible_aux);
                total_parcial += Convert.ToDouble(importe);
            }
        }

    }
}
