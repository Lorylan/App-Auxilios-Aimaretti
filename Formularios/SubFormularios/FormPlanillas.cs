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
using AuxiliosAimaretti.BaseDeDatos;

namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    public partial class FormPlanillas : Form
    {
        ServicioBD servicioBD;
        ClienteBD clienteBD;
        TarifaPactadaDB tarifaPactadaBD;
        CombustibleBD combustibleBD;
        TipoBD tipoBD;
        private void cargarOpciones()
        {
            DataSet dataset = clienteBD.MostrarInfo();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                txt_Empresa.Items.Add((string)row["NombreEmpresa"]);
            }
        }
        private void cargarTipos() {

            DataSet dataset = tipoBD.ObtenerTipos();
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                txt_tipo.Items.Add((string)row["Nombre"]);
            }
            
        }
        private Servicio RecuperarInfo()
        {
            return new Servicio(txt_Fecha.Value.ToString().Split(' ')[0],txt_codigo.Text,txt_desde.Text,txt_hasta.Text,
                txt_montoCobrado.Text,txt_observaciones.Text,txt_vehiculo.Text,txt_patente.Text,
                 txt_color.Text,txt_desperfecto.Text, txt_km.Text, txt_movil.Text,
                txt_Empresa.Text,txt_tipo.Text,txt_Importe.Text);
        }
        private bool InfoValida()
        {
            if ((txt_codigo.Text.Trim().Equals("")) | (txt_tipo.Text.Trim().Equals("")) | (txt_desde.Text.Trim().Equals("")) | (txt_hasta.Text.Trim().Equals("")) 
                | (txt_km.Text.Trim().Equals("")) | (txt_montoCobrado.Text.Trim().Equals("")) | (txt_Importe.Text.Trim().Equals(""))
                )
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
            
        }
        private void sacarMensajeError()
        {
            txt_error.Visible = false;
            
        }
        private void ActualizarInfoTabla()
        {
            datosServicios.DataSource = servicioBD.MostrarInfo(txt_Empresa.Text).Tables[0];
            datosServicios.Columns[0].Visible = false; //id
            datosServicios.Columns[1].HeaderText = "Fecha";
            datosServicios.Columns[2].HeaderText = "Codigo";
            datosServicios.Columns[3].HeaderText = "Tipo";
            datosServicios.Columns[4].HeaderText = "Vehiculo";
            datosServicios.Columns[5].HeaderText = "Patente";
            datosServicios.Columns[6].HeaderText = "Color";
            datosServicios.Columns[7].HeaderText = "Desperfecto";
            datosServicios.Columns[8].HeaderText = "Movil";
            datosServicios.Columns[9].HeaderText = "Desde";
            datosServicios.Columns[10].HeaderText = "Hasta";
            datosServicios.Columns[11].HeaderText = "Km";
            datosServicios.Columns[12].HeaderText = "MontoCobrado";
            datosServicios.Columns[13].HeaderText = "Importe";
            datosServicios.Columns[14].HeaderText = "Observaciones";
            datosServicios.Columns[15].Visible = false; //usuario
            datosServicios.Columns.RemoveAt(datosServicios.Columns.Count - 1);
            txt_cantidad_servicios.Text = datosServicios.Rows.Count.ToString();
           
            string total_importe_servicio = servicioBD.CalcularTotal(txt_Empresa.Text);
            string total_importe_combustible= combustibleBD.CalcularTotal(txt_Empresa.Text);
            int total;
            if ((total_importe_servicio.Equals("")) & (total_importe_combustible.Equals("")))
            {
                txt_importe_servicio.Text = "$0,00";
                txt_total_servicio.Text = "$0,00";
            }
            else {
                if (total_importe_servicio.Equals("") & (!total_importe_combustible.Equals("")))
                {
                    txt_total_servicio.Text = "$" + total_importe_combustible;
                    txt_importe_servicio.Text = "$0,00";
                }
                else
                {
                    if (!total_importe_servicio.Equals("") & (total_importe_combustible.Equals("")))
                    {
                        txt_importe_servicio.Text = "$0,00";
                        txt_total_servicio.Text = "$" + total_importe_servicio;
                    }
                    else {
                        total = int.Parse(total_importe_servicio) - int.Parse(total_importe_combustible) ;
                        txt_importe_servicio.Text = "$" + total_importe_servicio;
                        txt_total_servicio.Text = "$" + total.ToString();
                    }
                        
                }
                    
            }
            
        }
        private void vaciarTxt()
        {
            txt_Fecha.Value = DateTime.Now;
            txt_codigo.Text = "";
            txt_tipo.Text = "";
            txt_vehiculo.Text = "";
            txt_patente.Text = "";
            txt_desde.Text = "";
            txt_hasta.Text = "";
            txt_km.Text = "";
            txt_montoCobrado.Text = "";
            txt_Importe.Text = "";
            txt_color.Text = "";
            txt_movil.Text = "";
            txt_desperfecto.Text = "";
            txt_observaciones.Text = "";
            txt_usuario.Text = "";
            
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

        /*--------------------------------------------------------------*/
        public FormPlanillas()
        {
            InitializeComponent();
            
            desactivarBotones(new ButtonRedondeado[] {btn_agregar,btn_borrar,btn_cancelar,btn_editar,
            }, Color.Silver);
            
            servicioBD = new ServicioBD();
            clienteBD = new ClienteBD();
            tarifaPactadaBD = new TarifaPactadaDB();
            combustibleBD = new CombustibleBD();
            tipoBD = new TipoBD();
            cargarOpciones();
            cargarTipos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Enabled == true)
            {
                if (InfoValida() == true)
                {
                    sacarMensajeError();
                    servicioBD.Agregar(RecuperarInfo());
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
                int i = datosServicios.CurrentRow.Index;
                int id = int.Parse(datosServicios.Rows[i].Cells[0].Value.ToString());
                servicioBD.Modificar(RecuperarInfo(), id);
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

                Servicio c = RecuperarInfo();
                ConfirmarBorrado form = new ConfirmarBorrado(new string[] { "Fecha:" + c.Fecha, "Importe: $" + c.Importe });
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int i = datosServicios.CurrentRow.Index;
                    servicioBD.Borrar(int.Parse(datosServicios.Rows[i].Cells[0].Value.ToString()));
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

        private void txt_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Empresa.Text == "")
            {
                desactivarBoton(btn_agregar, Color.Silver);
                txt_filtrar.Text = "";
            }
            else
            {
                txt_filtrar.Enabled = true;
                activarBoton(btn_agregar, Color.FromArgb(251, 229, 0));
                ActualizarInfoTabla();

            }
        }

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int i = e.RowIndex;
                txt_Fecha.Text = datosServicios.Rows[i].Cells[1].Value.ToString();
                txt_codigo.Text = datosServicios.Rows[i].Cells[2].Value.ToString();
                txt_tipo.Text= datosServicios.Rows[i].Cells[3].Value.ToString();
                txt_vehiculo.Text = datosServicios.Rows[i].Cells[4].Value.ToString();
                txt_patente.Text = datosServicios.Rows[i].Cells[5].Value.ToString();
                txt_color.Text= datosServicios.Rows[i].Cells[6].Value.ToString();
                txt_desperfecto.Text = datosServicios.Rows[i].Cells[7].Value.ToString();
                txt_movil.Text = datosServicios.Rows[i].Cells[8].Value.ToString();
                txt_desde.Text = datosServicios.Rows[i].Cells[9].Value.ToString();
                txt_hasta.Text = datosServicios.Rows[i].Cells[10].Value.ToString();
                txt_km.Text = datosServicios.Rows[i].Cells[11].Value.ToString();
                txt_montoCobrado.Text = datosServicios.Rows[i].Cells[12].Value.ToString();
                txt_Importe.Text = datosServicios.Rows[i].Cells[13].Value.ToString();
                txt_observaciones.Text = datosServicios.Rows[i].Cells[14].Value.ToString();
                txt_usuario.Text = datosServicios.Rows[i].Cells[15].Value.ToString();
                activarBorrarEditarCancelar();
                desactivarBoton(btn_agregar, Color.Silver);
               
            }
            catch
            {

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

        private void soloNumerosReales(object sender, KeyPressEventArgs e)
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

        private void FormPlanillas_Load(object sender, EventArgs e)
        {

        }

        private void txt_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool aux = tarifaPactadaBD.ExisteTarifaDe(txt_Empresa.Text, txt_tipo.Text);
            if (aux)
            {
                if (!txt_tipo.Text.Equals("Servicio con Km"))
                {
                    txt_Importe.Text = tarifaPactadaBD.BuscarTarifaDe(txt_Empresa.Text, txt_tipo.Text);
                }
            }
            else 
            {
                txt_Importe.Text = "";
            }
        }

        private void txt_km_TextChanged(object sender, EventArgs e)
        {
            if (txt_tipo.Text.Equals("Servicio con Km"))
            {
                bool aux = tarifaPactadaBD.ExisteTarifaDe(txt_Empresa.Text, txt_tipo.Text);
                try
                {
                    if ((aux) & (int.Parse(txt_km.Text) > 0))
                    {
                        txt_Importe.Text = (int.Parse(tarifaPactadaBD.BuscarTarifaDe(txt_Empresa.Text, txt_tipo.Text)) * int.Parse(txt_km.Text)).ToString();
                    }
                    else
                    {
                        txt_Importe.Text = "";
                    }
                }
                catch
                {
                    txt_Importe.Text = "";
                }

            }
            else {
                if ((!txt_Empresa.Text.Trim().Equals("")) && (!txt_tipo.Text.Trim().Equals(""))) {
                    bool existe_tarifa = tarifaPactadaBD.ExisteTarifaDe(txt_Empresa.Text, txt_tipo.Text);
                    if (existe_tarifa) {
                        double importe = Convert.ToDouble(tarifaPactadaBD.BuscarTarifaDe(txt_Empresa.Text, txt_tipo.Text));

                        if (!txt_km.Text.Trim().Equals(""))
                        {
                            if (tarifaPactadaBD.ExisteTarifaDe(txt_Empresa.Text, "Km"))
                            {
                                double precio_por_km = Convert.ToDouble(tarifaPactadaBD.BuscarTarifaDe(txt_Empresa.Text, "Km"));

                                double cant_km = Convert.ToDouble(txt_km.Text);
                                txt_Importe.Text = (importe + (precio_por_km * cant_km)).ToString();
                            }

                        }
                        else
                        {
                            txt_Importe.Text = importe.ToString();
                        }
                    }

                }
            }
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txt_filtrar.Text.Equals(""))
                {
                    ((DataTable)datosServicios.DataSource).DefaultView.RowFilter = txt_por.Text + " like '"+ txt_filtrar.Text + "%'";
                }
                else {
                    ((DataTable)datosServicios.DataSource).DefaultView.RowFilter = null;
                }
            }
            catch {
                ((DataTable)datosServicios.DataSource).DefaultView.RowFilter = null;
            }
            
        }
    }
}
