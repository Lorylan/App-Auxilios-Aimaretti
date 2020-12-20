using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuxiliosAimaretti.Clases;
using AuxiliosAimaretti.BaseDeDatos;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.Hosting;

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class FormPersonal : Form
    {
        PersonalDB personalDB;
        public FormPersonal()
        {
            personalDB = new PersonalDB();
            InitializeComponent();
            ActualizarInfoTabla();
            desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Enabled == true) {
                if (InfoValida() == true)
                {
                    sacarMensajeError();
                    personalDB.Agregar(RecuperarInfo());
                    actualizarTablaVaciarTxt();
                }
                else {
                    mostrarMensajeError();
                }
            }
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (btn_borrar.Enabled == true) {
                
                Personal p = RecuperarInfo();
                ConfirmarBorrado form = new ConfirmarBorrado(new string[] { "Nombre: "+p.Nombre,"Apellido: "+p.Apellido });
                if (form.ShowDialog() == DialogResult.OK) {
                    personalDB.Borrar(RecuperarInfo());
                    actualizarTablaVaciarTxt();
                    vaciarTxt();
                    activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                    desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
                }
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (btn_editar.Enabled == true) {
                int i = datosPersonal.CurrentRow.Index;
                personalDB.Modificar(RecuperarInfo(), datosPersonal.Rows[i].Cells[2].Value.ToString());
                actualizarTablaVaciarTxt();
                vaciarTxt();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (btn_cancelar.Enabled == true) {
                vaciarTxt();
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                desactivarBotones(new ButtonRedondeado[] { btn_borrar, btn_cancelar, btn_editar }, Color.Silver);
            }
        }
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = e.RowIndex;
                txt_documento.Text = datosPersonal.Rows[i].Cells[2].Value.ToString();
                txt_nombre.Text = datosPersonal.Rows[i].Cells[0].Value.ToString();
                txt_apellido.Text = datosPersonal.Rows[i].Cells[1].Value.ToString();
                txt_telefono.Text = datosPersonal.Rows[i].Cells[3].Value.ToString();
                txt_email.Text = datosPersonal.Rows[i].Cells[4].Value.ToString();
                string aux = datosPersonal.Rows[i].Cells[5].Value.ToString();
                foreach (string dato in aux.Split('-')) {
                    txt_categoriaRegistro.SelectedItem = dato;
                }
                activarBorrarEditarCancelar();
                desactivarBoton(btn_agregar, Color.Silver);
            }
            catch { 
            
            }
        }
        private void soloNumeros(KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') & (e.KeyChar <= '9')) | (e.KeyChar == '\b') | (e.KeyChar.ToString() == "+"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /*--------------------------- Mis metodos -------------------------------------------*/
        private Personal RecuperarInfo() {
            string categoriaRegistro = "";
            foreach (string aux in txt_categoriaRegistro.SelectedItems) {
                categoriaRegistro += aux.ToString() + "-";
            }
            return new Personal(txt_documento.Text, txt_nombre.Text, txt_apellido.Text,
                    txt_telefono.Text, txt_email.Text, categoriaRegistro);
        }
        private bool InfoValida() {
            if ((txt_apellido.Text.Trim().Equals("")) | (txt_categoriaRegistro.SelectedItems.Count == 0) | (txt_documento.Text.Trim().Equals(""))
                | (txt_email.Text.Trim().Equals("")) | (txt_nombre.Text.Trim().Equals("")) | (txt_telefono.Text.Trim().Equals("")))
            {
                return false;
            } 
            else {
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
            txt_error.Visible = false ;
            pb_error.Visible = false;
        }
        private void ActualizarInfoTabla() {
            datosPersonal.DataSource = personalDB.MostrarInfo().Tables[0];

        }
        private void vaciarTxt() {
            txt_documento.Text = "";
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            txt_categoriaRegistro.ClearSelected();
        }
        private void desactivarBotones(ButtonRedondeado[] botones, Color c) {
            foreach (ButtonRedondeado aux in botones) {
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
        private void activarBorrarEditarCancelar(){
            activarBoton(btn_editar, Color.FromArgb(251, 229, 0));
            activarBoton(btn_cancelar, Color.FromArgb(230, 54, 104));
            activarBoton(btn_borrar, Color.FromArgb(230, 54, 104));
        }
        private void actualizarTablaVaciarTxt() {
            vaciarTxt();
            ActualizarInfoTabla();
        }
    }
}
