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
            Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
            Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel_general = new System.Windows.Forms.Panel();
            this.btn_pagoCliente = new System.Windows.Forms.Button();
            this.panel_botonSeleccionado = new System.Windows.Forms.Panel();
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
            bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_general.SuspendLayout();
            this.panel_formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
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
            // btn_pagoCliente
            // 
            this.btn_pagoCliente.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_pagoCliente.UseWaitCursor = true;
            this.btn_pagoCliente.Click += new System.EventHandler(this.btn_pagoCliente_Click);
            this.btn_pagoCliente.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            this.btn_pagoCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseMove);
            // 
            // panel_botonSeleccionado
            // 
            this.panel_botonSeleccionado.BackColor = System.Drawing.Color.Gold;
            this.panel_botonSeleccionado.Location = new System.Drawing.Point(0, 192);
            this.panel_botonSeleccionado.Name = "panel_botonSeleccionado";
            this.panel_botonSeleccionado.Size = new System.Drawing.Size(10, 37);
            this.panel_botonSeleccionado.TabIndex = 50;
            this.panel_botonSeleccionado.TabStop = true;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 663);
            this.panel1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
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
    }
}