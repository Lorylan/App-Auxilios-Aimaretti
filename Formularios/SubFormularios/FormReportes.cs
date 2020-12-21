using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuxiliosAimaretti.Clases;
using AuxiliosAimaretti.BaseDeDatos;

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class FormReportes : Form
    {
        public Boolean eligioEmpresa = false;
        public Boolean eligioTipoReporte = false;
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            ClienteBD cliente = new ClienteBD();
            DataSet dataset = cliente.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                txt_empresa.Items.Add((string)row["NombreEmpresa"]);
            }
            desactivarBoton(btn_agregar, Color.Silver);
            this.reporte_servicio.RefreshReport();
            this.reporte_pago_cliente.RefreshReport();
            this.reporte_liquidacion.RefreshReport();
        }
        private void cargarReporteCombustible(String desde, String hasta, String empresa) {
            reporte_combustible reporte_c = new reporte_combustible();
            reporte_c.createReporteCombustible(desde, hasta, empresa);
            reportecombustibleBindingSource.DataSource = reporte_c;
            listcombustibleBindingSource.DataSource = reporte_c.list_combustible;
            this.reporte_combustible.RefreshReport();
            
        }
        private void cargarReportePagoCliente(String desde, String hasta, String empresa)
        {
            reporte_pago_cliente reporte_pc = new reporte_pago_cliente();
            reporte_pc.createReportePagoCliente(desde, hasta, empresa);
            reportepagoclienteBindingSource.DataSource = reporte_pc;
            listpagoclienteBindingSource.DataSource = reporte_pc.list_pago_cliente;
            this.reporte_pago_cliente.RefreshReport();

        }

        private void cargarReporteServicio(String desde, String hasta, String empresa)
        {
            reporte_servicios reporte_s = new reporte_servicios();
            reporte_s.createReporteServicio(desde, hasta, empresa);
            reporteserviciosBindingSource.DataSource = reporte_s;
            listservicioBindingSource.DataSource = reporte_s.list_servicio;
            this.reporte_servicio.RefreshReport();

        }
        private void cargarReporteLiquidacion(String desde, String hasta, String empresa) {
            reporte_liquidacion reporte_l = new reporte_liquidacion();
            reporte_l.createReporteLiquidacion(desde, hasta, empresa);
            reporte_liquidacionBindingSource.DataSource = reporte_l;
            this.reporte_liquidacion.RefreshReport();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            String fecha_inicio = txt_desde.Value.Date.ToString().Split(' ')[0];
            String fecha_fin = txt_hasta.Value.Date.ToString().Split(' ')[0];
            String empresa = txt_empresa.Text;

            if (txt_tipo_de_reporte.Text.Equals("Combustible")) {
                cargarReporteCombustible(fecha_inicio, fecha_fin,empresa);
                reporte_combustible.Visible = true;
                reporte_pago_cliente.Visible = false;
                reporte_servicio.Visible = false;
                reporte_liquidacion.Visible = false;
            }
            if (txt_tipo_de_reporte.Text.Equals("Pagos clientes")) {
                cargarReportePagoCliente(fecha_inicio, fecha_fin, empresa);
                reporte_combustible.Visible = false;
                reporte_pago_cliente.Visible = true;
                reporte_servicio.Visible = false;
                reporte_liquidacion.Visible = false;
            }
            if (txt_tipo_de_reporte.Text.Equals("Servicio")) {
                cargarReporteServicio(fecha_inicio, fecha_fin, empresa);
                reporte_combustible.Visible = false;
                reporte_pago_cliente.Visible = false;
                reporte_servicio.Visible = true;
                reporte_liquidacion.Visible = false;
            }
            if (txt_tipo_de_reporte.Text.Equals("Liquidacion")) {
                cargarReporteServicio(fecha_inicio, fecha_fin, empresa);
                reporte_combustible.Visible = false;
                reporte_pago_cliente.Visible = false;
                reporte_liquidacion.Visible = true;
                reporte_servicio.Visible = false;
            }
        }
        private void desactivarBoton(ButtonRedondeado b, Color c)
        {
            b.Enabled = false;
            b.BorderColor = c;
        }
        private void activarBoton(ButtonRedondeado b, Color c)
        {
            b.Enabled = true;
            b.BorderColor = c;
        }

        private void txt_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            eligioEmpresa = true;
            if (eligioTipoReporte) {
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
            }
        }

        private void tipo_de_reporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            eligioTipoReporte = true;
            if (eligioEmpresa)
            {
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                reporte_combustible.Visible = false;
                reporte_pago_cliente.Visible = false;
                reporte_servicio.Visible = false;

            }
        }

     
    }
}
