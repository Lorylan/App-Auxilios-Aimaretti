using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuebaDeDiseñoAA.Clases;

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            
        }
        private void cargarReporteCombustible(String desde, String hasta, String empresa) {
            reporte_combustible reporte_c = new reporte_combustible();
            reporte_c.createReporteCombustible(desde, hasta, empresa);
            reportecombustibleBindingSource.DataSource = reporte_c;
            combustibleBindingSource.DataSource = reporte_c.list_combustible;
            this.reportViewer1.RefreshReport();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            cargarReporteCombustible(txt_desde.Value.Date.ToString().Split(' ')[0], txt_hasta.Value.Date.ToString().Split(' ')[0], "vazquez");
        }
    }
}
