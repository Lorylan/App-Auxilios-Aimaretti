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
    public partial class FormPagoClientes : Form{
        ClienteBD clienteBD;

        private void diseable_campos() {
            txt_detalle.Enabled = false;
            txt_detalle.BackColor = Color.Silver;
            txt_fecha.Enabled = false;
            txt_fecha.BackColor = Color.Silver;
            txt_nro_cuenta.Enabled = false;
            txt_nro_cuenta.BackColor = Color.Silver;
            txt_banco.Enabled = false;
            txt_banco.BackColor = Color.Silver;
            txt_nro.Enabled = false;
            txt_nro.BackColor = Color.Silver;
        }
        private void activarBoton(ButtonRedondeado b, Color c)
        {
            b.Enabled = true;
            b.BorderColor = c;
        }
        private void desactivarBotones(ButtonRedondeado[] botones, Color c)
        {
            foreach (ButtonRedondeado aux in botones)
            {
                aux.Enabled = false;
                aux.BorderColor = c;
            }
        }
        private void cargarOpciones() {
            DataSet dataset = clienteBD.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows){
                txt_Empresa.Items.Add((string)row["NombreEmpresa"]);
            }
        }
        public FormPagoClientes(){
            clienteBD = new ClienteBD();
            InitializeComponent();
            desactivarBotones(new ButtonRedondeado[] { btn_agregar, btn_borrar, btn_editar, btn_cancelar }, Color.Silver);
            txt_Empresa.BackColor = Color.White;
            diseable_campos();
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
        private void txt_Empresa_SelectedIndexChanged(object sender, EventArgs e){
            if (!sender.ToString().Equals("")) {
                cargar_datos();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));

            }
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void txt_opcion_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_opcion_pago.Text.Equals("Efectivo")){
                diseable_campos();
                txt_detalle.Enabled = true;
                txt_detalle.BackColor = Color.White;
            }
            else {
                diseable_campos();
                txt_fecha.Enabled = true;
                txt_fecha.BackColor = Color.White;
                txt_nro_cuenta.Enabled = true;
                txt_nro_cuenta.BackColor = Color.White;
                txt_banco.Enabled = true;
                txt_banco.BackColor = Color.White;
                txt_nro.Enabled = true;
                txt_nro.BackColor = Color.White;
            }
        }
    }
}
