using AuxiliosAimaretti.BaseDeDatos;
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

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class FormConfiguracionUsuario : Form
    {
        UsuarioDB usuarioDB;
        private void mostrarMensajeError(Label txt, PictureBox pb)
        {
            txt.Visible = true;
            pb.Visible = true;
        }
        private void sacarMensajeError(Label[] txt, PictureBox pb)
        {
            pb.Visible = false;
            foreach (Label aux in txt) {
                aux.Visible = false;
            }
        }
        public void vaciarTxt(TextBox[] txt) {
            foreach (TextBox aux in txt) {
                aux.Text = "";
            }
        }
        public void cambiarContraseña(PictureBox pbMostrar,PictureBox pbOcultar,TextBox txt, bool mostrar) {
            pbMostrar.Visible = true;
            pbOcultar.Visible = false;
            txt.UseSystemPasswordChar =mostrar;
        }
        /*-----------------------------*/
        public FormConfiguracionUsuario()
        {
            InitializeComponent();
            usuarioDB = new UsuarioDB();
            cambiarContraseña(pb_noVerContraseña, pb_verContraseña,txt_contraseña, true);
            cambiarContraseña(pb_noVerContraseñaActual, pb_verContraseñaActual,txt_ContraseñaActual, true);
            cambiarContraseña(pb_noVerRepetirNContraseña, pb_verRepetirNContraseña, txt_repertirContraseña,true);
            cambiarContraseña(pb_noVerNuevaContraseña, pb_verNuevaContraseña,txt_NuevaContraseña,true);
            cambiarContraseña(pb_noVerRepetirNContraseña, pb_verRepetirNContraseña, txt_NuevaContraseña2, true);
        }
        private void btn_cambiarContraseña_Click(object sender, EventArgs e)
        {
            sacarMensajeError(new Label[] { txt_errorCc,txt_errorContraseña,txt_errorContraseñaActual,txt_exitoContrseña}, pb_errorCc);
            if ((txt_ContraseñaActual.Text.Trim().Equals("")) | (txt_NuevaContraseña.Text.Trim().Equals("")) | (txt_NuevaContraseña2.Text.Trim().Equals("")))
            {
                mostrarMensajeError(txt_errorCc, pb_errorCc);
            }
            else {
                sacarMensajeError(new Label[] { txt_errorCc, txt_errorContraseña, txt_errorContraseñaActual, txt_exitoContrseña }, pb_errorCc);
                if (usuarioDB.Existe(new Usuario(Program.nombreUsuario,txt_ContraseñaActual.Text)))
                {
                    txt_errorContraseñaActual.Visible = false; 
                    if (txt_NuevaContraseña.Text.Equals(txt_NuevaContraseña2.Text))
                    {
                        sacarMensajeError(new Label[] { txt_errorCc, txt_errorContraseña, txt_errorContraseñaActual, txt_exitoContrseña }, pb_errorCc);
                        txt_errorContraseña.Visible = false;
                        usuarioDB.ModificarContraseña(txt_NuevaContraseña.Text, Program.nombreUsuario);
                        vaciarTxt(new TextBox[] { txt_NuevaContraseña, txt_NuevaContraseña2, txt_ContraseñaActual });
                        txt_exitoContrseña.Visible = true;
                        
                    }
                    else
                    {
                        txt_errorContraseña.Visible = true;
                        mostrarMensajeError(txt_errorContraseña, pb_errorCc);
                    }
                }
                else {
                    txt_errorContraseñaActual.Visible = true;
                    mostrarMensajeError(txt_errorContraseñaActual, pb_errorCc);
                }
                
            }
        }
        private void btn_crearCuenta_Click(object sender, EventArgs e)
        {
            txt_exitoCuenta.Visible = false;
            txt_errorCuenta.Visible = false;
            txt_errorContraseñaDistintas.Visible = false;
            sacarMensajeError(new Label[]{txt_errorCuenta,txt_exitoCuenta,txt_errorContraseñaDistintas,txt_errorCcuenta}, pb_errorCcuenta);
            if ((txt_nombre.Text.Trim().Equals("")) | (txt_contraseña.Text.Trim().Equals("")) | (txt_repertirContraseña.Text.Trim().Equals(""))) {
                mostrarMensajeError(txt_errorCcuenta, pb_errorCcuenta);
            }
            else{
               // sacarMensajeError(txt_errorCcuenta, pb_errorCcuenta);
                if (usuarioDB.nombreRepetido(txt_nombre.Text))
                {
                    txt_errorCuenta.Visible = true;
                    mostrarMensajeError(txt_errorCuenta, pb_errorCcuenta);
                }
                else
                {
                    sacarMensajeError(new Label[] { txt_errorCuenta, txt_exitoCuenta, txt_errorContraseñaDistintas, txt_errorCcuenta }, pb_errorCcuenta);
                    if (txt_contraseña.Text.Equals(txt_repertirContraseña.Text))
                    {
                        
                        txt_errorContraseñaDistintas.Visible = false;
                        usuarioDB.Agregar(new Usuario(txt_nombre.Text, txt_contraseña.Text));
                        vaciarTxt(new TextBox[] { txt_nombre, txt_contraseña, txt_repertirContraseña });
                        txt_exitoCuenta.Visible = true;
                    }
                    else
                    {
                        txt_errorContraseñaDistintas.Visible = true;
                        mostrarMensajeError(txt_errorContraseñaDistintas, pb_errorCcuenta);
                    }
                }
            }
        }
        private void pb_noVerContraseñaActual_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_verContraseñaActual, pb_noVerContraseñaActual, txt_ContraseñaActual, false);
        }
        private void pb_verContraseñaActual_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_noVerContraseñaActual, pb_verContraseñaActual, txt_ContraseñaActual, true);
        }
        private void pc_verNuevaContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_noVerNuevaContraseña, pb_verNuevaContraseña, txt_NuevaContraseña, true);
        }
        private void pb_noVerNuevaContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_verNuevaContraseña, pb_noVerNuevaContraseña,  txt_NuevaContraseña, false);
        }
        private void pb_noVerRepetirNContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_verRepetirNContraseña, pb_noVerRepetirNContraseña, txt_NuevaContraseña2, false);
        }
        private void pb_verRepetirNContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_noVerRepetirNContraseña, pb_verRepetirNContraseña, txt_NuevaContraseña2, true);
        }
        private void pb_noVerContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_verContraseña, pb_noVerContraseña, txt_contraseña, false); 
        }
        private void pb_verContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_noVerContraseña, pb_verContraseña, txt_contraseña, true);
        }
        private void pb_noVerRepetirContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_verRepetirContraseña, pb_noVerRepetirContraseña,  txt_repertirContraseña, false);
        }
        private void pv_verRepetirContraseña_Click(object sender, EventArgs e)
        {
            cambiarContraseña(pb_noVerRepetirContraseña, pb_verRepetirContraseña, txt_repertirContraseña, true);
        }
        
    }
}
