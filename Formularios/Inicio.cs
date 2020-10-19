using PuebaDeDiseñoAA.Clases;
using PuebaDeDiseñoAA.Formularios.SubFormularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuebaDeDiseñoAA
{
    public partial class Inicio : Form
    {

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
        /* ----------------------- Metodos mios ------------------------------*/
        private void cambiarLetraColor(Button b, Color c)
        {
            b.ForeColor = c;
        }
        private void BotonSeleccionado(Point newLocation) {
            panel_botonSeleccionado.Location = newLocation;
            panel_botonSeleccionado.Visible = true;
            
        }
        private void ArreglaTamañoPantalla(Point p, Size s, bool maxVisible, bool resVisible) {
            Location = p;
            Size = s;
            panel_separarMenuA.Size = new System.Drawing.Size(42, panel_general.Size.Height);
            panel_formularios.Size = new Size((s.Width-235),(s.Height-60));
        }
        private void abrirFormulario(Form nuevoFormulario){
            if (panel_formularios.Controls.Count != 0) {
                panel_formularios.Controls.RemoveAt(0);
            }
            nuevoFormulario.TopLevel = false;
            panel_formularios.Controls.Add(nuevoFormulario);
            panel_formularios.Tag = nuevoFormulario;
            nuevoFormulario.Show();
        }
        private void ClickBotonesMenu(Point p, Form formaularioNuevo) {
            BotonSeleccionado(p);
            abrirFormulario(formaularioNuevo);
        }
        /* -------------------------------------------------------------------*/
        public Inicio()
        {
            InitializeComponent();
           
        }
        /*--------------------------------------- Botones Menu -----------------------------------*/
        
        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            cambiarLetraColor((Button)sender, Color.White);
        }
        private void buttons_MouseMove(object sender, MouseEventArgs e)
        {
            cambiarLetraColor((Button)sender, Color.Black);
        }
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_cliente.Location, new FormClientes());
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_usuario.Location, new FormConfiguracionUsuario());
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_personal.Location, new FormPersonal());
        }

        private void btn_planillas_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_planillas.Location, new FormPlanillas());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_reportes.Location, new FormReportes());
        }

        private void btn_combustible_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_combustible.Location, new FormCombustible());
        }
        private void btn_pagoCliente_Click(object sender, EventArgs e)
        {
            ClickBotonesMenu(btn_pagoCliente.Location, new FormPagoClientes());
        }
        /*-------------------------------------------------------------------------*/

        /*------------------------------ Botones Salir-Minimizar-Agrandar ------------------------------*/
        private void pictureBox_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*-------------------------------------------------------------------------*//*-------------------------------------------------------------------------*/
        private void Inicio_Load(object sender, EventArgs e)
        {
            ArreglaTamañoPantalla(new Point(0, 0), Screen.PrimaryScreen.WorkingArea.Size, false, true);
        }

        
    }
}
