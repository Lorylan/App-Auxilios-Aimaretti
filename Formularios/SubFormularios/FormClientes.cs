using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuebaDeDiseñoAA.BaseDeDatos;
using PuebaDeDiseñoAA.Clases;

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    public partial class FormClientes : Form
    {
        ClienteBD clienteDB;
        TarifaPactadaDB tarifaPactadaDB;
        /*-------------------------- Mi metodos -----------------------------*/
        private void desactivarBotones(ButtonRedondeado[] botones, Color c)
        {
            foreach (ButtonRedondeado aux in botones)
            {
                aux.Enabled = false;
                aux.BorderColor = c;
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
        private void ActualizarInfoTablaCliente()
        {
            datosCliente.DataSource = clienteDB.MostrarInfo().Tables[0];
            datosCliente.Columns[0].HeaderText = "Nombre empresa";
            datosCliente.Columns[1].HeaderText = "Ciut";
            datosCliente.Columns[2].HeaderText = "Email";
            datosCliente.Columns[3].HeaderText = "Telefono";
            datosCliente.Columns[4].HeaderText = "Cuenta bancaria";
            datosCliente.Columns[5].HeaderText = "CBU";
            datosCliente.Columns[6].HeaderText = "Domicilio";
            datosCliente.Columns[7].HeaderText = "Observaciones";
        }
        private void ActualizarInfoTablaTarifaP() {
            DataSet aux = tarifaPactadaDB.MostrarInfoDe(txt_nombreEmpresa.Text);
            if (aux.Tables.Count != 0) {
                datosTarifaPactada.DataSource = aux.Tables[0];
                datosTarifaPactada.Columns[0].HeaderText = "Tipo";
                datosTarifaPactada.Columns[1].HeaderText = "Importe";
                datosTarifaPactada.Columns.RemoveAt(datosTarifaPactada.Columns.Count-1);
            }
        }
        private Cliente RecuperarInfoCliente()
        {
            return new Cliente(txt_nombreEmpresa.Text,txt_cuit.Text, txt_domicilio.Text, 
                    txt_telefono.Text, txt_email.Text,txt_cuentaBancaria.Text, txt_cbu.Text,txt_observaciones.Text);
        }
        private TarifaPactada RecuperarInfoTp() {
            return new TarifaPactada(txt_nombreEmpresa.Text,txt_tipo.Text,txt_importe.Text);
        }
        private bool InfoValidaCliente()
        {
            if ((txt_nombreEmpresa.Text.Trim().Equals("") | (txt_cuit.Text.Trim().Equals("")) | (txt_domicilio.Text.Trim().Equals(""))
                | (txt_cuentaBancaria.Text.Trim().Equals("")) | (txt_email.Text.Trim().Equals("")) | (txt_telefono.Text.Trim().Equals(""))))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool InfoValidaTp() {
            if ((!txt_tipo.Text.Trim().Equals("")) & (!txt_importe.Text.Trim().Equals("")))
            {
                return true;
            }
            else {
                return false;
            }
        }
        private void activarBorrarEditarCancelar()
        {
            activarBoton(btn_editar, Color.FromArgb(251, 229, 0));
            activarBoton(btn_cancelar, Color.FromArgb(230, 54, 104));
            activarBoton(btn_borrar, Color.FromArgb(230, 54, 104));
        }
        private void activarEditarCancelarTp() {
            activarBoton(btn_editartp, Color.FromArgb(251, 229, 0));
            activarBoton(btn_cancelartp, Color.FromArgb(230, 54, 104));
        }
        private void mostrarMensajeErrorCliente(Label txt, PictureBox pb)
        {
           txt.Visible = true;
            pb.Visible = true;
        }
        private void sacarMensajeError(Label txt, PictureBox pb)
        {
            txt.Visible = false;
            pb.Visible = false;
        }
        private void vaciarTxtCliente() {
            txt_nombreEmpresa.Text = "";
            txt_email.Text = "";
            txt_cbu.Text = "";
            txt_cuentaBancaria.Text = "";
            txt_cuit.Text = "";
            txt_domicilio.Text = "";
            txt_observaciones.Text = "";
            txt_telefono.Text = "";
        }
        private void actualizarTablaVaciarTxtCliente()
        {
            vaciarTxtCliente();
            ActualizarInfoTablaCliente();
        }
        private void vaciarTxtTp() {
            txt_tipo.Text = "";
            txt_importe.Text = "";
        }
        private void actualizarTablaVaciarTxtTp()
        {
            vaciarTxtTp();
            ActualizarInfoTablaTarifaP();
        }

        /*------------------------------------------------------------------*/
        public FormClientes()
        {
            InitializeComponent();
            clienteDB = new ClienteBD();
            tarifaPactadaDB = new TarifaPactadaDB();
            desactivarBotones(new ButtonRedondeado[] {btn_borrar,btn_cancelar,btn_editar,btn_agregartp,btn_cancelartp,btn_editartp},Color.Silver);
            ActualizarInfoTablaCliente();
        }
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int i = e.RowIndex;
                txt_nombreEmpresa.Text = datosCliente.Rows[i].Cells[0].Value.ToString();
                txt_observaciones.Text = datosCliente.Rows[i].Cells[7].Value.ToString();
                txt_cuit.Text = datosCliente.Rows[i].Cells[1].Value.ToString();
                txt_domicilio.Text = datosCliente.Rows[i].Cells[6].Value.ToString();
                txt_telefono.Text = datosCliente.Rows[i].Cells[3].Value.ToString();
                txt_email.Text = datosCliente.Rows[i].Cells[2].Value.ToString();
                txt_cuentaBancaria.Text = datosCliente.Rows[i].Cells[4].Value.ToString();
                txt_cbu.Text = datosCliente.Rows[i].Cells[5].Value.ToString();
                activarBorrarEditarCancelar();
                activarBoton(btn_agregartp, Color.FromArgb(251, 229, 0));
                desactivarBoton(btn_agregar, Color.Silver);
                ActualizarInfoTablaTarifaP();
            }
            catch { 
            
            }

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Enabled == true) {
                if (InfoValidaCliente())
                {
                    sacarMensajeError(txt_error,pb_error);
                    clienteDB.Agregar(RecuperarInfoCliente());
                    actualizarTablaVaciarTxtCliente();
                }
                else
                {
                    mostrarMensajeErrorCliente(txt_error, pb_error);
                }
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (btn_editar.Enabled == true) {
                int i = datosCliente.CurrentRow.Index;
                clienteDB.Modificar(RecuperarInfoCliente(), datosCliente.Rows[i].Cells[0].Value.ToString());
                actualizarTablaVaciarTxtCliente();
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar, btn_agregartp, btn_cancelartp, btn_editartp }, Color.Silver);
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
            }
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Cliente c = RecuperarInfoCliente();
            ConfirmarBorrado form = new ConfirmarBorrado(new string[] {"Nombre empresa: "+c.NombreEmpresa,"Email: "+c.Email});
            if (form.ShowDialog() == DialogResult.OK)
            {
                clienteDB.Borrar(RecuperarInfoCliente());
                tarifaPactadaDB.BorrarDe(txt_nombreEmpresa.Text);
                actualizarTablaVaciarTxtCliente();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                actualizarTablaVaciarTxtCliente();
                actualizarTablaVaciarTxtTp();
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar, btn_agregartp, btn_cancelartp, btn_editartp }, Color.Silver);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (btn_cancelar.Enabled == true) {
                vaciarTxtCliente();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar, btn_agregartp}, Color.Silver);
                actualizarTablaVaciarTxtCliente();
            }
        }
        private void btn_agregartp_Click(object sender, EventArgs e)
        {
            if (btn_agregartp.Enabled == true)
            {
                if (InfoValidaTp())
                {
                    sacarMensajeError(txt_errortp, pb_errortp);
                    tarifaPactadaDB.Agregar(RecuperarInfoTp());
                    actualizarTablaVaciarTxtTp();
                }
                else
                {
                    mostrarMensajeErrorCliente(txt_errortp, pb_errortp);
                }
            }
        }
        private void btn_editartp_Click(object sender, EventArgs e)
        {
            if (btn_editar.Enabled == true)
            {
                int i = datosTarifaPactada.CurrentRow.Index;
                tarifaPactadaDB.Modificar(RecuperarInfoTp(),txt_nombreEmpresa.Text, datosTarifaPactada.Rows[i].Cells[0].Value.ToString());
                actualizarTablaVaciarTxtTp();
                desactivarBotones(new ButtonRedondeado[] { btn_cancelartp, btn_editartp, btn_agregartp }, Color.Silver);
               
            }
        }
        private void btn_cancelartp_Click(object sender, EventArgs e)
        {
            if (btn_cancelar.Enabled == true)
            {
                vaciarTxtTp();
                desactivarBotones(new ButtonRedondeado[] { btn_cancelartp, btn_editartp, btn_agregartp }, Color.Silver);
                actualizarTablaVaciarTxtTp();
            }
        }
        private void SeleccionarTp(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int i = e.RowIndex;
                txt_tipo.Text = datosTarifaPactada.Rows[i].Cells[0].Value.ToString();
                txt_importe.Text = datosTarifaPactada.Rows[i].Cells[1].Value.ToString();
                activarEditarCancelarTp();
                desactivarBoton(btn_agregartp, Color.Silver);
                ActualizarInfoTablaTarifaP();
            }catch{ 
            
            }
        }
        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') & (e.KeyChar <= '9')) | (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /*---------------------------------------------------*/
    }
}
