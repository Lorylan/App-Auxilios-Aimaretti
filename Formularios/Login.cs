using Microsoft.VisualBasic.Devices;
using PuebaDeDiseñoAA.BaseDeDatos;
using PuebaDeDiseñoAA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PuebaDeDiseñoAA
{
    public partial class Login : Form
    {
        private UsuarioDB usuarioDB;
        /* ------------------- Mis metodos--------------------------*/
        private void cambiarTextoUsusario(string textoNuevo)
        {
            txt_user.Text = textoNuevo;
        }
        private void cambiarTextoContaseña(string textoNuevo, bool nuevoValor)
        {
            txt_pass.Text = textoNuevo;
            txt_pass.UseSystemPasswordChar = nuevoValor;
        }
        private void ponerTxtVacio()
        {
            txt_pass_vacio.Text = "";
            txt_user_vacio.Text = "";
            txt_error.Visible = false;
        }
        private bool cheuqueoDeLabels()
        {
            bool resu = true;
            ponerTxtVacio();
            if ((txt_user.Text == "") | (txt_user.Text == "USUARIO"))
            {
                txt_user_vacio.Text = "Nombre de usuario requerido"; resu = false;
            }
            if ((txt_pass.Text == "") | (txt_pass.Text == "CONTRASEÑA"))
            {
                txt_pass_vacio.Text = "Contraseña requerida"; resu = false;
            }
            return resu;
        }
        /* ---------------------------------------------------------------*/
        public Login()
        {
            InitializeComponent();
            usuarioDB = new UsuarioDB();
        }
        private void button_acceder_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txt_user.Text,txt_pass.Text);
            if (cheuqueoDeLabels()) { }
                if (usuarioDB.Existe(user))
                {
                    Program.nombreUsuario = user.Nombre;
                    Inicio form2 = new Inicio();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    txt_error.Visible = true;
                    cambiarTextoUsusario("USUARIO");
                    cambiarTextoContaseña("CONTRASEÑA", false);
                }
            }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "CONTRASEÑA")
            {
                cambiarTextoContaseña("", true);
            }
        }
        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                cambiarTextoUsusario("USUARIO");
            }
        }
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USUARIO")
            {
                cambiarTextoUsusario("");
            }
        }
        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                cambiarTextoContaseña("CONTRASEÑA", false);
            }
        }
        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button_acceder_Click(this, new EventArgs());
            }
        }
    }
}
