using AuxiliosAimaretti.BaseDeDatos;
using AuxiliosAimaretti.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class FormPagoClientes : Form{
        ClienteBD clienteBD;
        PagoClienteBD pagoClienteBD;

        private void visibilidad_obligatorio(Boolean bol)
        {
            obligatorio.Visible = bol;
            obligatorio1.Visible = bol;
            obligatorio2.Visible = bol;
            obligatorio3.Visible = bol;
        }
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
        private void sacarMensajeError()
        {
            txt_error.Visible = false;
            pb_error.Visible = false;
        }
        private void cargarOpciones() {
            DataSet dataset = clienteBD.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows){
                txt_Empresa.Items.Add((string)row["NombreEmpresa"]);
            }
            
        }
        private void mostrarMensajeError()
        {
            txt_error.Visible = true;
            pb_error.Visible = true;
        }
        private bool InfoValida()
        {
            if ((txt_comprobante_nro.Text.Trim().Equals("")) | (txt_monto.Text.Trim().Equals("")) | (txt_comprobante_nro.Text.Trim().Equals("")))
            {
                return false;
            }
            if (txt_opcion_pago.Text.Trim().Equals("Transferencia bancaria") && ((txt_nro.Text.Trim().Equals("")) |
                (txt_banco.Text.Trim().Equals("")) | (txt_nro_cuenta.Text.Trim().Equals(""))))
            {
                return false;
            }
            return true;
        }
        private void cargar_datos_empresa()
        {
            datos_cliente.DataSource = clienteBD.Mostrar_info_de(txt_Empresa.Text).Tables[0];
            txt_cuit.Text = datos_cliente.Rows[0].Cells[1].Value.ToString();
            txt_email.Text = datos_cliente.Rows[0].Cells[2].Value.ToString();
            txt_telefono.Text = datos_cliente.Rows[0].Cells[3].Value.ToString();
            txt_cuentaBancaria.Text = datos_cliente.Rows[0].Cells[4].Value.ToString();
            txt_cbu.Text = datos_cliente.Rows[0].Cells[5].Value.ToString();
            txt_domicilio.Text = datos_cliente.Rows[0].Cells[6].Value.ToString();
            txt_obs.Text = datos_cliente.Rows[0].Cells[7].Value.ToString();
            ActualizarInfoTabla();
        }
        private void actualizarTablaVaciarTxt()
        {
            vaciarTxt();
            ActualizarInfoTabla();
        }
        private PagoCliente RecuperarInfo() {
            if (txt_opcion_pago.Text.Equals("Efectivo"))
            {
                return new PagoCliente(txt_comprobante_nro.Text,txt_Fecha_c.Value.ToString().Split(' ')[0],txt_monto.Text,"-","-","-",
                    "-",txt_detalle.Text,txt_Empresa.Text,"Efectivo");
            }
            else {
                return new PagoCliente(txt_comprobante_nro.Text, txt_Fecha_c.Value.ToString().Split(' ')[0], txt_monto.Text, 
                    txt_nro.Text,txt_banco.Text,txt_nro_cuenta.Text,
                    txt_fecha.Value.Date.ToString().Split(' ')[0], txt_detalle.Text, txt_Empresa.Text, "" +
                    "Transferencia bancaria");
            }
            
        }
        private void vaciarTxt() {
            txt_comprobante_nro.Text = "";
            txt_monto.Text = "";
            txt_nro.Text = "";
            txt_banco.Text = "";
            txt_nro_cuenta.Text = "";
            txt_detalle.Text = "";
        }
        private void ActualizarInfoTabla()
        {
            datos_pago.DataSource = pagoClienteBD.MostrarInfo().Tables[0];
            datos_pago.Columns[0].HeaderText=  "Nro. de comprobante";
            datos_pago.Columns[1].HeaderText = "Fecha";
            datos_pago.Columns[2].HeaderText = "Monto";
            datos_pago.Columns[3].HeaderText = "Nro. de cheque";
            datos_pago.Columns[4].HeaderText = "Banco";
            datos_pago.Columns[5].HeaderText = "Nro. de cuenta";
            datos_pago.Columns[6].HeaderText = "Fecha";
            datos_pago.Columns[7].HeaderText = "Detalle";
            datos_pago.Columns[8].Visible = false;
            datos_pago.Columns[9].Visible = false;
            datos_pago.Columns[10].Visible = false;
        }
        private void desactivarBoton(ButtonRedondeado b, Color c)
        {
            b.Enabled = false;
            b.BorderColor = c;
        }
        private void activarBorrarEditarCancelar()
        {
            activarBoton(btn_editar, Color.FromArgb(251, 229, 0));
            activarBoton(btn_cancelar, Color.FromArgb(230, 54, 104));
            activarBoton(btn_borrar, Color.FromArgb(230, 54, 104));
        }
        public FormPagoClientes(){
            clienteBD = new ClienteBD();
            pagoClienteBD = new PagoClienteBD();
            InitializeComponent();
            desactivarBotones(new ButtonRedondeado[] { btn_agregar, btn_borrar, btn_editar, btn_cancelar }, Color.Silver);
            txt_Empresa.BackColor = Color.White;
            diseable_campos();
            visibilidad_obligatorio(false);
            cargarOpciones();
        }
       
        private void txt_Empresa_SelectedIndexChanged(object sender, EventArgs e){
            if (!sender.ToString().Equals("")) {
                cargar_datos_empresa();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));

            }   
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Enabled == true)
            {
                if (InfoValida() == true)
                {
                    sacarMensajeError();
                    pagoClienteBD.Agregar(RecuperarInfo());
                    actualizarTablaVaciarTxt();
                }
                else
                {
                    mostrarMensajeError();
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (btn_editar.Enabled == true)
            {
                txt_opcion_pago.Enabled = true;
                int i = datos_pago.CurrentRow.Index;
                string comprobante = datos_pago.Rows[i].Cells[0].Value.ToString();
                pagoClienteBD.Modificar(RecuperarInfo(),comprobante );
                actualizarTablaVaciarTxt();
                vaciarTxt();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (btn_borrar.Enabled == true)
            {
                txt_opcion_pago.Enabled = true;
                PagoCliente pc = RecuperarInfo();
                ConfirmarBorrado form = new ConfirmarBorrado(new string[] { "Nro. Comprobante:" + pc.ComprobanteNro, "Monto: $" +pc.Monto });
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int i = datos_pago.CurrentRow.Index;
                    pagoClienteBD.Borrar(datos_pago.Rows[i].Cells[0].Value.ToString());
                    actualizarTablaVaciarTxt();
                    activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                    desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (btn_cancelar.Enabled == true)
            {
                txt_opcion_pago.Enabled = true;
                vaciarTxt();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
            }
        }

        private void txt_opcion_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_opcion_pago.Text.Equals("Efectivo")){
                visibilidad_obligatorio(false);
                diseable_campos();
                txt_detalle.Enabled = true;
                txt_detalle.BackColor = Color.White;
                
            }
            else {
                diseable_campos();
                visibilidad_obligatorio(true);
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

        private void solo_monto(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') & (e.KeyChar <= '9')) | (e.KeyChar == '\b') | (e.KeyChar.ToString() == "."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void solo_numero_barra_guion(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') & (e.KeyChar <= '9')) | (e.KeyChar == '\b') | (e.KeyChar.ToString() == ".") | (e.KeyChar.ToString() == "-") | (e.KeyChar.ToString() == "/"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txt_comprobante_nro.Text = datos_pago.Rows[i].Cells[0].Value.ToString();
                txt_Fecha_c.Text = datos_pago.Rows[i].Cells[1].Value.ToString();
                txt_monto.Text = datos_pago.Rows[i].Cells[2].Value.ToString();
                txt_nro.Text = datos_pago.Rows[i].Cells[3].Value.ToString();
                txt_banco.Text = datos_pago.Rows[i].Cells[4].Value.ToString();
                txt_nro_cuenta.Text = datos_pago.Rows[i].Cells[5].Value.ToString();
                txt_fecha.Text = datos_pago.Rows[i].Cells[6].Value.ToString();
                txt_detalle.Text = datos_pago.Rows[i].Cells[7].Value.ToString();
                string buscar = datos_pago.Rows[i].Cells[10].Value.ToString().Trim();
                int id_item = txt_opcion_pago.Items.IndexOf(buscar);
                txt_opcion_pago.SelectedIndex = id_item;
                activarBorrarEditarCancelar();
                desactivarBoton(btn_agregar, Color.Silver);
                txt_opcion_pago.Enabled = false;
            }
            catch { }
        }
    }
}
