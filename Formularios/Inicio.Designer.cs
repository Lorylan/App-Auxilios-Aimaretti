using System.Drawing;

namespace PuebaDeDiseñoAA
{
    partial class Inicio
    {
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
            Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel_general = new System.Windows.Forms.Panel();
            this.panel_botonSeleccionado = new System.Windows.Forms.Panel();
            this.btn_pagoCliente = new System.Windows.Forms.Button();
            this.btn_combustible = new System.Windows.Forms.Button();
            this.panel_formularios = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_separarMenuA = new System.Windows.Forms.Panel();
            this.btn_personal = new System.Windows.Forms.Button();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_planillas = new System.Windows.Forms.Button();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.datos_pago_hoy = new System.Windows.Forms.DataGridView();
            this.datos_pago_recordatorio = new System.Windows.Forms.DataGridView();
            bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_general.SuspendLayout();
            this.panel_formularios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_pago_hoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_pago_recordatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            bunifuSeparator1.ForeColor = System.Drawing.Color.Transparent;
            bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            bunifuSeparator1.LineThickness = 1;
            bunifuSeparator1.Location = new System.Drawing.Point(26, 161);
            bunifuSeparator1.Name = "bunifuSeparator1";
            bunifuSeparator1.Size = new System.Drawing.Size(145, 10);
            bunifuSeparator1.TabIndex = 0;
            bunifuSeparator1.Transparency = 255;
            bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            bunifuSeparator2.ForeColor = System.Drawing.Color.Transparent;
            bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            bunifuSeparator2.LineThickness = 2;
            bunifuSeparator2.Location = new System.Drawing.Point(26, 364);
            bunifuSeparator2.Name = "bunifuSeparator2";
            bunifuSeparator2.Size = new System.Drawing.Size(145, 10);
            bunifuSeparator2.TabIndex = 11;
            bunifuSeparator2.Transparency = 255;
            bunifuSeparator2.Vertical = false;
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_usuario.Location = new System.Drawing.Point(3, 466);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(184, 37);
            this.btn_usuario.TabIndex = 1;
            this.btn_usuario.Text = "Configuracion usuario";
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            this.btn_usuario.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_usuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Location = new System.Drawing.Point(3, 321);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(184, 37);
            this.btn_cliente.TabIndex = 4;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_clientes_Click);
            this.btn_cliente.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // panel_general
            // 
            this.panel_general.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_general.BackColor = System.Drawing.Color.Black;
            this.panel_general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_general.Controls.Add(this.panel_botonSeleccionado);
            this.panel_general.Controls.Add(this.btn_pagoCliente);
            this.panel_general.Controls.Add(bunifuSeparator2);
            this.panel_general.Controls.Add(this.btn_combustible);
            this.panel_general.Controls.Add(bunifuSeparator1);
            this.panel_general.Controls.Add(this.panel_formularios);
            this.panel_general.Controls.Add(this.panel_separarMenuA);
            this.panel_general.Controls.Add(this.btn_personal);
            this.panel_general.Controls.Add(this.btn_cliente);
            this.panel_general.Controls.Add(this.pictureBox_minimizar);
            this.panel_general.Controls.Add(this.btn_reportes);
            this.panel_general.Controls.Add(this.btn_planillas);
            this.panel_general.Controls.Add(this.pictureBox_cerrar);
            this.panel_general.Controls.Add(this.btn_usuario);
            this.panel_general.Controls.Add(this.panel_logo);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_general.Location = new System.Drawing.Point(0, 0);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(1077, 706);
            this.panel_general.TabIndex = 0;
            // 
            // panel_botonSeleccionado
            // 
            this.panel_botonSeleccionado.BackColor = System.Drawing.Color.Gold;
            this.panel_botonSeleccionado.Location = new System.Drawing.Point(0, 192);
            this.panel_botonSeleccionado.Name = "panel_botonSeleccionado";
            this.panel_botonSeleccionado.Size = new System.Drawing.Size(10, 37);
            this.panel_botonSeleccionado.TabIndex = 50;
            this.panel_botonSeleccionado.TabStop = true;
            this.panel_botonSeleccionado.Visible = false;
            // 
            // btn_pagoCliente
            // 
            this.btn_pagoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_pagoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_pagoCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pagoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pagoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_pagoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagoCliente.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagoCliente.ForeColor = System.Drawing.Color.White;
            this.btn_pagoCliente.Location = new System.Drawing.Point(0, 278);
            this.btn_pagoCliente.Name = "btn_pagoCliente";
            this.btn_pagoCliente.Size = new System.Drawing.Size(184, 37);
            this.btn_pagoCliente.TabIndex = 22;
            this.btn_pagoCliente.Text = "Pago Cliente";
            this.btn_pagoCliente.UseVisualStyleBackColor = false;
            this.btn_pagoCliente.Click += new System.EventHandler(this.btn_pagoCliente_Click);
            this.btn_pagoCliente.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_pagoCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // btn_combustible
            // 
            this.btn_combustible.BackColor = System.Drawing.Color.Transparent;
            this.btn_combustible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_combustible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_combustible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_combustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_combustible.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_combustible.ForeColor = System.Drawing.Color.White;
            this.btn_combustible.Location = new System.Drawing.Point(0, 235);
            this.btn_combustible.Name = "btn_combustible";
            this.btn_combustible.Size = new System.Drawing.Size(184, 37);
            this.btn_combustible.TabIndex = 10;
            this.btn_combustible.Text = "Carga de combustible";
            this.btn_combustible.UseVisualStyleBackColor = false;
            this.btn_combustible.Click += new System.EventHandler(this.btn_combustible_Click);
            this.btn_combustible.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_combustible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // panel_formularios
            // 
            this.panel_formularios.AutoScroll = true;
            this.panel_formularios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_formularios.BackColor = System.Drawing.Color.Black;
            this.panel_formularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_formularios.Controls.Add(this.panel1);
            this.panel_formularios.Location = new System.Drawing.Point(223, 43);
            this.panel_formularios.Name = "panel_formularios";
            this.panel_formularios.Size = new System.Drawing.Size(851, 663);
            this.panel_formularios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.panel1.BackgroundImage = global::PuebaDeDiseñoAA.Properties.Resources.WhatsApp_Image_2020_06_15_at_9_13_14_AM;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.datos_pago_recordatorio);
            this.panel1.Controls.Add(this.datos_pago_hoy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 663);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_separarMenuA
            // 
            this.panel_separarMenuA.AutoScroll = true;
            this.panel_separarMenuA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_separarMenuA.BackColor = System.Drawing.Color.Transparent;
            this.panel_separarMenuA.BackgroundImage = global::PuebaDeDiseñoAA.Properties.Resources.SeparadorMEnuAriiba;
            this.panel_separarMenuA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_separarMenuA.Location = new System.Drawing.Point(184, 0);
            this.panel_separarMenuA.Name = "panel_separarMenuA";
            this.panel_separarMenuA.Size = new System.Drawing.Size(42, 703);
            this.panel_separarMenuA.TabIndex = 7;
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.Transparent;
            this.btn_personal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_personal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_personal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Location = new System.Drawing.Point(3, 380);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(184, 37);
            this.btn_personal.TabIndex = 5;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            this.btn_personal.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_personal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Image = global::PuebaDeDiseñoAA.Properties.Resources.Minimize_Window_2_48px;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(1007, 12);
            this.pictureBox_minimizar.Name = "pictureBox_minimizar";
            this.pictureBox_minimizar.Size = new System.Drawing.Size(26, 25);
            this.pictureBox_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimizar.TabIndex = 4;
            this.pictureBox_minimizar.TabStop = false;
            this.pictureBox_minimizar.Click += new System.EventHandler(this.pictureBox_minimizar_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Location = new System.Drawing.Point(0, 423);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(184, 37);
            this.btn_reportes.TabIndex = 3;
            this.btn_reportes.Text = "Reportes de servicios";
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            this.btn_reportes.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_reportes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // btn_planillas
            // 
            this.btn_planillas.BackColor = System.Drawing.Color.Transparent;
            this.btn_planillas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_planillas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_planillas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_planillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_planillas.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_planillas.ForeColor = System.Drawing.Color.White;
            this.btn_planillas.Location = new System.Drawing.Point(0, 192);
            this.btn_planillas.Name = "btn_planillas";
            this.btn_planillas.Size = new System.Drawing.Size(184, 37);
            this.btn_planillas.TabIndex = 2;
            this.btn_planillas.Text = "Carga de servicios";
            this.btn_planillas.UseVisualStyleBackColor = false;
            this.btn_planillas.Click += new System.EventHandler(this.btn_planillas_Click);
            this.btn_planillas.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_planillas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // pictureBox_cerrar
            // 
            this.pictureBox_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_cerrar.Image = global::PuebaDeDiseñoAA.Properties.Resources.Close_Window__2_48px;
            this.pictureBox_cerrar.Location = new System.Drawing.Point(1039, 12);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(26, 25);
            this.pictureBox_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cerrar.TabIndex = 2;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.BackgroundImage = global::PuebaDeDiseñoAA.Properties.Resources.WhatsApp_Image_2020_06_15_at_9_13_14_AM;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Location = new System.Drawing.Point(3, 21);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(181, 124);
            this.panel_logo.TabIndex = 0;
            // 
            // notificacion
            // 
            this.notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificacion.BalloonTipText = "aaaaaaaaaaaaaa";
            this.notificacion.BalloonTipTitle = "aaaaaaaaaaaaaaaa";
            this.notificacion.Text = "aaaaaaaaaaaaaaaaaaa";
            this.notificacion.Visible = true;
            // 
            // datos_pago_hoy
            // 
            this.datos_pago_hoy.AllowUserToAddRows = false;
            this.datos_pago_hoy.AllowUserToDeleteRows = false;
            this.datos_pago_hoy.AllowUserToOrderColumns = true;
            this.datos_pago_hoy.AllowUserToResizeColumns = false;
            this.datos_pago_hoy.AllowUserToResizeRows = false;
            this.datos_pago_hoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datos_pago_hoy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datos_pago_hoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos_pago_hoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datos_pago_hoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_pago_hoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datos_pago_hoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datos_pago_hoy.DefaultCellStyle = dataGridViewCellStyle5;
            this.datos_pago_hoy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datos_pago_hoy.EnableHeadersVisualStyles = false;
            this.datos_pago_hoy.GridColor = System.Drawing.Color.Gold;
            this.datos_pago_hoy.Location = new System.Drawing.Point(142, 149);
            this.datos_pago_hoy.Name = "datos_pago_hoy";
            this.datos_pago_hoy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_pago_hoy.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datos_pago_hoy.RowHeadersVisible = false;
            this.datos_pago_hoy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datos_pago_hoy.RowTemplate.Height = 23;
            this.datos_pago_hoy.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_pago_hoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_pago_hoy.Size = new System.Drawing.Size(226, 23);
            this.datos_pago_hoy.TabIndex = 73;
            this.datos_pago_hoy.Visible = false;
            // 
            // datos_pago_recordatorio
            // 
            this.datos_pago_recordatorio.AllowUserToAddRows = false;
            this.datos_pago_recordatorio.AllowUserToDeleteRows = false;
            this.datos_pago_recordatorio.AllowUserToOrderColumns = true;
            this.datos_pago_recordatorio.AllowUserToResizeColumns = false;
            this.datos_pago_recordatorio.AllowUserToResizeRows = false;
            this.datos_pago_recordatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datos_pago_recordatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datos_pago_recordatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos_pago_recordatorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datos_pago_recordatorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_pago_recordatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datos_pago_recordatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datos_pago_recordatorio.DefaultCellStyle = dataGridViewCellStyle2;
            this.datos_pago_recordatorio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datos_pago_recordatorio.EnableHeadersVisualStyles = false;
            this.datos_pago_recordatorio.GridColor = System.Drawing.Color.Gold;
            this.datos_pago_recordatorio.Location = new System.Drawing.Point(195, 192);
            this.datos_pago_recordatorio.Name = "datos_pago_recordatorio";
            this.datos_pago_recordatorio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_pago_recordatorio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datos_pago_recordatorio.RowHeadersVisible = false;
            this.datos_pago_recordatorio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datos_pago_recordatorio.RowTemplate.Height = 23;
            this.datos_pago_recordatorio.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_pago_recordatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_pago_recordatorio.Size = new System.Drawing.Size(228, 54);
            this.datos_pago_recordatorio.TabIndex = 74;
            this.datos_pago_recordatorio.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1077, 706);
            this.Controls.Add(this.panel_general);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel_general.ResumeLayout(false);
            this.panel_formularios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_pago_hoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_pago_recordatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
        private System.Windows.Forms.Panel panel_separarMenuA;
        private System.Windows.Forms.Panel panel_botonSeleccionado;
        private System.Windows.Forms.Panel panel_formularios;
        internal System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.Button btn_combustible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_planillas;
        private System.Windows.Forms.Button btn_pagoCliente;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.DataGridView datos_pago_recordatorio;
        private System.Windows.Forms.DataGridView datos_pago_hoy;
    }
}