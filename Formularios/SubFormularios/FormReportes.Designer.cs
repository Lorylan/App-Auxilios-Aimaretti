namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    partial class FormReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txt_empresa = new System.Windows.Forms.ComboBox();
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.desde = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.Label();
            this.panel_cargaReporte = new System.Windows.Forms.Panel();
            this.datosReporte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo_de_reporte = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportecombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_cargaReporte.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportecombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_empresa
            // 
            this.txt_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_empresa.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_empresa.FormattingEnabled = true;
            this.txt_empresa.Location = new System.Drawing.Point(25, 57);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(188, 28);
            this.txt_empresa.TabIndex = 44;
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(16, 38);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(274, 28);
            this.txt_desde.TabIndex = 46;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta.Location = new System.Drawing.Point(16, 99);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(274, 28);
            this.txt_hasta.TabIndex = 47;
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.BackColor = System.Drawing.Color.Transparent;
            this.desde.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.desde.ForeColor = System.Drawing.Color.White;
            this.desde.Location = new System.Drawing.Point(12, 17);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(112, 20);
            this.desde.TabIndex = 48;
            this.desde.Text = "Desde la fecha";
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.BackColor = System.Drawing.Color.Transparent;
            this.hasta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.hasta.ForeColor = System.Drawing.Color.White;
            this.hasta.Location = new System.Drawing.Point(13, 78);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(51, 20);
            this.hasta.TabIndex = 49;
            this.hasta.Text = "Hasta";
            // 
            // panel_cargaReporte
            // 
            this.panel_cargaReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_cargaReporte.Controls.Add(this.desde);
            this.panel_cargaReporte.Controls.Add(this.txt_desde);
            this.panel_cargaReporte.Controls.Add(this.hasta);
            this.panel_cargaReporte.Controls.Add(this.txt_hasta);
            this.panel_cargaReporte.Location = new System.Drawing.Point(20, 271);
            this.panel_cargaReporte.Name = "panel_cargaReporte";
            this.panel_cargaReporte.Size = new System.Drawing.Size(302, 147);
            this.panel_cargaReporte.TabIndex = 57;
            // 
            // datosReporte
            // 
            this.datosReporte.AutoSize = true;
            this.datosReporte.BackColor = System.Drawing.Color.Transparent;
            this.datosReporte.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosReporte.ForeColor = System.Drawing.Color.Gold;
            this.datosReporte.Location = new System.Drawing.Point(20, 242);
            this.datosReporte.Name = "datosReporte";
            this.datosReporte.Size = new System.Drawing.Size(167, 26);
            this.datosReporte.TabIndex = 59;
            this.datosReporte.Text = "Datos del reporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total";
            // 
            // tipo_de_reporte
            // 
            this.tipo_de_reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_de_reporte.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.tipo_de_reporte.FormattingEnabled = true;
            this.tipo_de_reporte.Items.AddRange(new object[] {
            "Servicio",
            "Combustible",
            "Pagos clientes"});
            this.tipo_de_reporte.Location = new System.Drawing.Point(25, 147);
            this.tipo_de_reporte.Name = "tipo_de_reporte";
            this.tipo_de_reporte.Size = new System.Drawing.Size(188, 28);
            this.tipo_de_reporte.TabIndex = 80;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "datos_combustible";
            reportDataSource3.Value = this.combustibleBindingSource;
            reportDataSource4.Name = "datos_reporte";
            reportDataSource4.Value = this.reportecombustibleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PuebaDeDiseñoAA.Reporte.reporte_combustible.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(958, 1044);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datosReporte);
            this.panel1.Controls.Add(this.panel_cargaReporte);
            this.panel1.Controls.Add(this.tipo_de_reporte);
            this.panel1.Controls.Add(this.txt_empresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 1044);
            this.panel1.TabIndex = 81;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.btn_agregar.ButtonColor = System.Drawing.Color.Black;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_agregar.FlatAppearance.BorderSize = 3;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Location = new System.Drawing.Point(73, 433);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_agregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_agregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_agregar.Size = new System.Drawing.Size(186, 32);
            this.btn_agregar.TabIndex = 82;
            this.btn_agregar.Text = "Generar reporte";
            this.btn_agregar.TextColor = System.Drawing.Color.White;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tipo de reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Elija una empresa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(342, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 1044);
            this.panel2.TabIndex = 82;
            // 
            // reportecombustibleBindingSource
            // 
            this.reportecombustibleBindingSource.DataSource = typeof(PuebaDeDiseñoAA.Clases.reporte_combustible);
            // 
            // combustibleBindingSource
            // 
            this.combustibleBindingSource.DataSource = typeof(PuebaDeDiseñoAA.Clases.Combustible);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.Text = "FormPlanillaVazquez";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.panel_cargaReporte.ResumeLayout(false);
            this.panel_cargaReporte.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportecombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_empresa;
        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Panel panel_cargaReporte;
        private System.Windows.Forms.Label datosReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipo_de_reporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ButtonRedondeado btn_agregar;
        private System.Windows.Forms.BindingSource combustibleBindingSource;
        private System.Windows.Forms.BindingSource reportecombustibleBindingSource;
    }
}