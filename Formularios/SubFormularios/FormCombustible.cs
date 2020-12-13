using PuebaDeDiseñoAA.BaseDeDatos;
using PuebaDeDiseñoAA.Clases;
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

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    public partial class FormCombustible : Form
    {
        CombustibleBD combustibleBD;
        ClienteBD clienteBD;

        
        private void cargarOpciones() {

            DataSet dataset = clienteBD.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                txt_opciones.Items.Add((string)row["NombreEmpresa"]);
            }

        }
        private Combustible RecuperarInfo()
        {
            string[] fecha = txt_fecha.Value.ToString().Split(' ');
            return new Combustible(fecha[0], txt_litros.Text,txt_importe.Text,txt_opciones.Text);
        }
        private bool InfoValida()
        {
            if ((txt_importe.Text.Trim().Equals("")) | (txt_litros.Text.Trim().Equals("")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void mostrarMensajeError()
        {
            txt_error.Visible = true;
            pb_error.Visible = true;
        }
        private void sacarMensajeError()
        {
            txt_error.Visible = false;
            pb_error.Visible = false;
        }
        private void ActualizarInfoTabla()
        {
            datosCombustible.DataSource = combustibleBD.MostrarInfo(txt_opciones.Text).Tables[0];
            datosCombustible.Columns[0].Visible = false;
            datosCombustible.Columns[1].HeaderText = "Fecha";
            datosCombustible.Columns[2].HeaderText = "Litros";
            datosCombustible.Columns[3].HeaderText = "Importe";
            datosCombustible.Columns[4].HeaderText = "Usuario";
            datosCombustible.Columns.RemoveAt(datosCombustible.Columns.Count - 1);
            string aux = combustibleBD.CalcularTotal(txt_opciones.Text);
            if (aux == "") {
                txt_total.Text = "$0,00";
            }
            else
            {
                txt_total.Text = "$"+ aux;
            }
        }
        private void vaciarTxt()
        {
            txt_litros.Text = "";
            txt_importe.Text = "";

        }
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
        private void activarBorrarEditarCancelar()
        {
            activarBoton(btn_editar, Color.FromArgb(251, 229, 0));
            activarBoton(btn_cancelar, Color.FromArgb(230, 54, 104));
            activarBoton(btn_borrar, Color.FromArgb(230, 54, 104));
        }
        private void actualizarTablaVaciarTxt()
        {
            vaciarTxt();
            ActualizarInfoTabla();
        }
        /*------------------------------------------*/
        public FormCombustible()
        {
            InitializeComponent();
            desactivarBotones(new ButtonRedondeado[] {btn_agregar,btn_borrar,btn_cancelar,btn_editar,
            }, Color.Silver);
            combustibleBD = new CombustibleBD();
            clienteBD = new ClienteBD();
            cargarOpciones();
        }
        private void txt_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_opciones.Text == "")
            {
                desactivarBoton(btn_agregar,Color.Silver);
            }
            else {
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                ActualizarInfoTabla();
                
            }
        }
        private void soloNumeros(object sender, KeyPressEventArgs e)
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
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txt_fecha.Text = datosCombustible.Rows[i].Cells[1].Value.ToString();
                txt_importe.Text = datosCombustible.Rows[i].Cells[3].Value.ToString();
                txt_litros.Text = datosCombustible.Rows[i].Cells[2].Value.ToString();
                activarBorrarEditarCancelar();
                desactivarBoton(btn_agregar, Color.Silver);
            }
            catch{}
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Enabled == true)
            {
                if (InfoValida() == true)
                {
                    sacarMensajeError();
                    combustibleBD.Agregar(RecuperarInfo());
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
                int i = datosCombustible.CurrentRow.Index;
                int id = int.Parse(datosCombustible.Rows[i].Cells[0].Value.ToString());
                combustibleBD.Modificar(RecuperarInfo(), id);
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

                Combustible c = RecuperarInfo();
                ConfirmarBorrado form = new ConfirmarBorrado(new string[] { "Fecha:" +c.Fecha, "Importe: $"+c.Importe});
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int i = datosCombustible.CurrentRow.Index;
                    combustibleBD.Borrar(int.Parse(datosCombustible.Rows[i].Cells[0].Value.ToString()));
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
                vaciarTxt();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
            }
        }
    }
}

