using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuxiliosAimaretti.BaseDeDatos;
using AuxiliosAimaretti.Clases;

namespace AuxiliosAimaretti.Clases
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

            var list_pc = pagoClienteBD.MostrarDesdeHasta(desde, hasta,empresa);
            total_parcial = 0;
            cant_pago_cliente = 0;
            String comprobante;
            String monto;
            String fechaEmision;
            String nro_cheque;
            String nro_cuenta;
            String fecha_cobro;
            String nro_factura;
            foreach (System.Data.DataRow rows in list_pc.Rows)
            {
                comprobante = Convert.ToString(rows[0]);
                monto = Convert.ToString(rows[2]);
                fechaEmision = Convert.ToString(rows[1]);
                nro_cheque = Convert.ToString(rows[3]);
                nro_cuenta = Convert.ToString(rows[5]);
                fecha_cobro = Convert.ToString(rows[6]);
                nro_factura = Convert.ToString(rows[11]);
                pagoCliente_aux = new PagoCliente(comprobante,fechaEmision,monto,nro_cheque,"",nro_cuenta,fecha_cobro,"","","",nro_factura);
                
                list_pago_cliente.Add(pagoCliente_aux);
            }
            cant_pago_cliente = list_pc.Rows.Count;
            try
            {
                total_parcial = Convert.ToDouble(pagoClienteBD.CalcularMontoTotalDe(desde, hasta, emp));
            }
            catch {
                total_parcial = 0;
            }
            
        }
    }
}
