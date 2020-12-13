using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuebaDeDiseñoAA.BaseDeDatos;
using PuebaDeDiseñoAA.Clases;

namespace PuebaDeDiseñoAA.Clases
{
    class reporte_pago_cliente:reporte
    {
        public List<PagoCliente> list_pago_cliente { get; private set; }
        public double cant_pago_cliente { get; private set; }
        public void createReportePagoCliente(String desde, String hasta, String emp)
        {
            this.empresa = emp;
            this.fecha_inicio = desde;
            this.fecha_fin = hasta;
            PagoClienteBD pagoClienteBD = new PagoClienteBD();
            list_pago_cliente = new List<PagoCliente>();
            PagoCliente pagoCliente_aux;

            var list_pc = pagoClienteBD.MostrarDesdeHasta(desde, hasta);
            total_parcial = 0;
            cant_pago_cliente = 0;

            String comprobante;
            String monto;
            String fechaEmision;
            String nro_cheque;
            String nro_cuenta;
            String fecha_cobro;

            foreach (System.Data.DataRow rows in list_pc.Rows)
            {
                comprobante = Convert.ToString(rows[1]);
                monto = Convert.ToString(rows[2]);
                fechaEmision = Convert.ToString(rows[4]);
                nro_cheque = Convert.ToString(rows[9]);
                nro_cuenta = Convert.ToString(rows[10]);
                fecha_cobro = Convert.ToString(rows[12]);
                pagoCliente_aux = new PagoCliente(comprobante,fechaEmision,monto,nro_cheque,"",nro_cuenta,fecha_cobro,"","","");
                
                list_pago_cliente.Add(pagoCliente_aux);
                total_parcial += Convert.ToDouble(monto);
            }
            cant_pago_cliente = list_pc.Rows.Count;
        }
    }
}
