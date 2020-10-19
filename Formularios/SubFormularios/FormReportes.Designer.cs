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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_empresa = new System.Windows.Forms.ComboBox();
            this.txt_desde = new System.Windows.Forms.DateTimePicker();
            this.txt_hasta = new System.Windows.Forms.DateTimePicker();
            this.desde = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.Label();
            this.guardarEn = new System.Windows.Forms.Label();
            this.txt_guardarEn = new System.Windows.Forms.TextBox();
            this.panel_cargaReporte = new System.Windows.Forms.Panel();
            this.btn_examinar = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.btn_genrarReporte = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.btn_vistaPrevia = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.datosReporte = new System.Windows.Forms.Label();
            this.vistaPrevia = new System.Windows.Forms.Label();
            this.panel_total = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_gasOil = new System.Windows.Forms.Label();
            this.txt_servicios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datos_vistaPrevia = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_cargaReporte.SuspendLayout();
            this.panel_total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_vistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_empresa
            // 
            this.txt_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_empresa.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_empresa.FormattingEnabled = true;
            this.txt_empresa.Location = new System.Drawing.Point(12, 12);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(188, 28);
            this.txt_empresa.TabIndex = 44;
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde.Location = new System.Drawing.Point(16, 38);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(242, 26);
            this.txt_desde.TabIndex = 46;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hasta.Location = new System.Drawing.Point(16, 99);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(242, 26);
            this.txt_hasta.TabIndex = 47;
            // 
            // desde
            // 
            this.desde.AutoSize = true;
            this.desde.BackColor = System.Drawing.Color.Transparent;
            this.desde.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.ForeColor = System.Drawing.Color.White;
            this.desde.Location = new System.Drawing.Point(12, 17);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(99, 18);
            this.desde.TabIndex = 48;
            this.desde.Text = "Desde la fecha";
            // 
            // hasta
            // 
            this.hasta.AutoSize = true;
            this.hasta.BackColor = System.Drawing.Color.Transparent;
            this.hasta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.ForeColor = System.Drawing.Color.White;
            this.hasta.Location = new System.Drawing.Point(13, 78);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(43, 18);
            this.hasta.TabIndex = 49;
            this.hasta.Text = "Hasta";
            // 
            // guardarEn
            // 
            this.guardarEn.AutoSize = true;
            this.guardarEn.BackColor = System.Drawing.Color.Transparent;
            this.guardarEn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarEn.ForeColor = System.Drawing.Color.White;
            this.guardarEn.Location = new System.Drawing.Point(12, 143);
            this.guardarEn.Name = "guardarEn";
            this.guardarEn.Size = new System.Drawing.Size(82, 18);
            this.guardarEn.TabIndex = 51;
            this.guardarEn.Text = "Guardar en..";
            // 
            // txt_guardarEn
            // 
            this.txt_guardarEn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guardarEn.Location = new System.Drawing.Point(15, 164);
            this.txt_guardarEn.Name = "txt_guardarEn";
            this.txt_guardarEn.Size = new System.Drawing.Size(162, 26);
            this.txt_guardarEn.TabIndex = 52;
            // 
            // panel_cargaReporte
            // 
            this.panel_cargaReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_cargaReporte.Controls.Add(this.desde);
            this.panel_cargaReporte.Controls.Add(this.txt_desde);
            this.panel_cargaReporte.Controls.Add(this.hasta);
            this.panel_cargaReporte.Controls.Add(this.txt_hasta);
            this.panel_cargaReporte.Controls.Add(this.btn_examinar);
            this.panel_cargaReporte.Controls.Add(this.guardarEn);
            this.panel_cargaReporte.Controls.Add(this.txt_guardarEn);
            this.panel_cargaReporte.Location = new System.Drawing.Point(12, 124);
            this.panel_cargaReporte.Name = "panel_cargaReporte";
            this.panel_cargaReporte.Size = new System.Drawing.Size(274, 202);
            this.panel_cargaReporte.TabIndex = 57;
            // 
            // btn_examinar
            // 
            this.btn_examinar.BackColor = System.Drawing.Color.Transparent;
            this.btn_examinar.BorderColor = System.Drawing.Color.Gold;
            this.btn_examinar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_examinar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_examinar.FlatAppearance.BorderSize = 3;
            this.btn_examinar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_examinar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_examinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_examinar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_examinar.Location = new System.Drawing.Point(189, 164);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_examinar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_examinar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_examinar.Size = new System.Drawing.Size(85, 29);
            this.btn_examinar.TabIndex = 75;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.TextColor = System.Drawing.Color.White;
            this.btn_examinar.UseVisualStyleBackColor = false;
            // 
            // btn_genrarReporte
            // 
            this.btn_genrarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btn_genrarReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.btn_genrarReporte.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_genrarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_genrarReporte.FlatAppearance.BorderSize = 3;
            this.btn_genrarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_genrarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_genrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genrarReporte.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_genrarReporte.ForeColor = System.Drawing.Color.Transparent;
            this.btn_genrarReporte.Location = new System.Drawing.Point(27, 332);
            this.btn_genrarReporte.Name = "btn_genrarReporte";
            this.btn_genrarReporte.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_genrarReporte.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_genrarReporte.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_genrarReporte.Size = new System.Drawing.Size(145, 29);
            this.btn_genrarReporte.TabIndex = 77;
            this.btn_genrarReporte.Text = "Generar reporte";
            this.btn_genrarReporte.TextColor = System.Drawing.Color.White;
            this.btn_genrarReporte.UseVisualStyleBackColor = false;
            // 
            // btn_vistaPrevia
            // 
            this.btn_vistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btn_vistaPrevia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.btn_vistaPrevia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_vistaPrevia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_vistaPrevia.FlatAppearance.BorderSize = 3;
            this.btn_vistaPrevia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_vistaPrevia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_vistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vistaPrevia.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_vistaPrevia.ForeColor = System.Drawing.Color.Transparent;
            this.btn_vistaPrevia.Location = new System.Drawing.Point(27, 383);
            this.btn_vistaPrevia.Name = "btn_vistaPrevia";
            this.btn_vistaPrevia.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_vistaPrevia.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_vistaPrevia.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_vistaPrevia.Size = new System.Drawing.Size(145, 29);
            this.btn_vistaPrevia.TabIndex = 76;
            this.btn_vistaPrevia.Text = "Vista previa";
            this.btn_vistaPrevia.TextColor = System.Drawing.Color.White;
            this.btn_vistaPrevia.UseVisualStyleBackColor = false;
            // 
            // datosReporte
            // 
            this.datosReporte.AutoSize = true;
            this.datosReporte.BackColor = System.Drawing.Color.Transparent;
            this.datosReporte.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosReporte.ForeColor = System.Drawing.Color.Gold;
            this.datosReporte.Location = new System.Drawing.Point(12, 78);
            this.datosReporte.Name = "datosReporte";
            this.datosReporte.Size = new System.Drawing.Size(167, 26);
            this.datosReporte.TabIndex = 59;
            this.datosReporte.Text = "Datos del reporte";
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.AutoSize = true;
            this.vistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.vistaPrevia.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaPrevia.ForeColor = System.Drawing.Color.Gold;
            this.vistaPrevia.Location = new System.Drawing.Point(330, 78);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(113, 26);
            this.vistaPrevia.TabIndex = 58;
            this.vistaPrevia.Text = "Vista previa";
            // 
            // panel_total
            // 
            this.panel_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_total.Controls.Add(this.txt_total);
            this.panel_total.Controls.Add(this.txt_gasOil);
            this.panel_total.Controls.Add(this.txt_servicios);
            this.panel_total.Location = new System.Drawing.Point(17, 487);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(202, 109);
            this.panel_total.TabIndex = 59;
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.BackColor = System.Drawing.Color.Transparent;
            this.txt_total.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(25, 81);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(57, 18);
            this.txt_total.TabIndex = 52;
            this.txt_total.Text = "Total: $";
            // 
            // txt_gasOil
            // 
            this.txt_gasOil.AutoSize = true;
            this.txt_gasOil.BackColor = System.Drawing.Color.Transparent;
            this.txt_gasOil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gasOil.ForeColor = System.Drawing.Color.White;
            this.txt_gasOil.Location = new System.Drawing.Point(25, 45);
            this.txt_gasOil.Name = "txt_gasOil";
            this.txt_gasOil.Size = new System.Drawing.Size(69, 18);
            this.txt_gasOil.TabIndex = 51;
            this.txt_gasOil.Text = "Gas Oil: $";
            // 
            // txt_servicios
            // 
            this.txt_servicios.AutoSize = true;
            this.txt_servicios.BackColor = System.Drawing.Color.Transparent;
            this.txt_servicios.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_servicios.ForeColor = System.Drawing.Color.White;
            this.txt_servicios.Location = new System.Drawing.Point(25, 11);
            this.txt_servicios.Name = "txt_servicios";
            this.txt_servicios.Size = new System.Drawing.Size(81, 18);
            this.txt_servicios.TabIndex = 50;
            this.txt_servicios.Text = "Servicios: $";
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
            // datos_vistaPrevia
            // 
            this.datos_vistaPrevia.AllowUserToAddRows = false;
            this.datos_vistaPrevia.AllowUserToDeleteRows = false;
            this.datos_vistaPrevia.AllowUserToOrderColumns = true;
            this.datos_vistaPrevia.AllowUserToResizeColumns = false;
            this.datos_vistaPrevia.AllowUserToResizeRows = false;
            this.datos_vistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datos_vistaPrevia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datos_vistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos_vistaPrevia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datos_vistaPrevia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_vistaPrevia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datos_vistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datos_vistaPrevia.DefaultCellStyle = dataGridViewCellStyle2;
            this.datos_vistaPrevia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datos_vistaPrevia.EnableHeadersVisualStyles = false;
            this.datos_vistaPrevia.GridColor = System.Drawing.Color.Gold;
            this.datos_vistaPrevia.Location = new System.Drawing.Point(326, 107);
            this.datos_vistaPrevia.Name = "datos_vistaPrevia";
            this.datos_vistaPrevia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_vistaPrevia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datos_vistaPrevia.RowHeadersVisible = false;
            this.datos_vistaPrevia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datos_vistaPrevia.RowTemplate.Height = 23;
            this.datos_vistaPrevia.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_vistaPrevia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_vistaPrevia.Size = new System.Drawing.Size(920, 669);
            this.datos_vistaPrevia.TabIndex = 79;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Servicio",
            "Combustible",
            "Pagos clientes"});
            this.comboBox1.Location = new System.Drawing.Point(219, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 80;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datos_vistaPrevia);
            this.Controls.Add(this.btn_genrarReporte);
            this.Controls.Add(this.btn_vistaPrevia);
            this.Controls.Add(this.panel_total);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datosReporte);
            this.Controls.Add(this.panel_cargaReporte);
            this.Controls.Add(this.txt_empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.Text = "FormPlanillaVazquez";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.panel_cargaReporte.ResumeLayout(false);
            this.panel_cargaReporte.PerformLayout();
            this.panel_total.ResumeLayout(false);
            this.panel_total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_vistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_empresa;
        private System.Windows.Forms.DateTimePicker txt_desde;
        private System.Windows.Forms.DateTimePicker txt_hasta;
        private System.Windows.Forms.Label desde;
        private System.Windows.Forms.Label hasta;
        private System.Windows.Forms.Label guardarEn;
        private System.Windows.Forms.TextBox txt_guardarEn;
        private System.Windows.Forms.Panel panel_cargaReporte;
        private System.Windows.Forms.Label datosReporte;
        private System.Windows.Forms.Label vistaPrevia;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label txt_gasOil;
        private System.Windows.Forms.Label txt_servicios;
        private System.Windows.Forms.Label label5;
        private ButtonRedondeado btn_genrarReporte;
        private ButtonRedondeado btn_vistaPrevia;
        private ButtonRedondeado btn_examinar;
        private System.Windows.Forms.DataGridView datos_vistaPrevia;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}