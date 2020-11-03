using PuebaDeDiseñoAA.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    public partial class FormPagoClientes : Form
    {
        ClienteBD clienteBD;
        private void cargarOpciones()
        {
            DataSet dataset = clienteBD.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                txt_Empresa.Items.Add((string)row["NombreEmpresa"]);
            }
        }
        public FormPagoClientes()
        {
            clienteBD = new ClienteBD();
            InitializeComponent();
            cargarOpciones();

        }
        private void cargar_datos() {
            datos_cliente.DataSource = clienteBD.Mostrar_info_de(txt_Empresa.Text).Tables[0];
            txt_cuit.Text = datos_cliente.Rows[0].Cells[1].Value.ToString();
            txt_email.Text = datos_cliente.Rows[0].Cells[2].Value.ToString();
            txt_telefono.Text = datos_cliente.Rows[0].Cells[3].Value.ToString();
            txt_cuentaBancaria.Text = datos_cliente.Rows[0].Cells[4].Value.ToString();
            txt_cbu.Text = datos_cliente.Rows[0].Cells[5].Value.ToString();
            txt_domicilio.Text = datos_cliente.Rows[0].Cells[6].Value.ToString();
            txt_obs.Text = datos_cliente.Rows[0].Cells[7].Value.ToString();
        }
        private void txt_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!sender.ToString().Equals(""))
            {
                cargar_datos();  
            }
            
        }
    }
}
