namespace AuxiliosAimaretti.Formularios.SubFormularios
{
    partial class FormCombustible
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_opciones = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel_cargaCombustible = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_litros = new System.Windows.Forms.TextBox();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.importe = new System.Windows.Forms.Label();
            this.litros = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoCombustible = new System.Windows.Forms.Label();
            this.txt_error = new System.Windows.Forms.Label();
            this.datosCombustible = new System.Windows.Forms.DataGridView();
            this.btn_editar = new AuxiliosAimaretti.ButtonRedondeado();
            this.btn_borrar = new AuxiliosAimaretti.ButtonRedondeado();
            this.btn_cancelar = new AuxiliosAimaretti.ButtonRedondeado();
            this.btn_agregar = new AuxiliosAimaretti.ButtonRedondeado();
            this.pb_error = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_cargaCombustible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_opciones
            // 
            this.txt_opciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opciones.FormattingEnabled = true;
            this.txt_opciones.Location = new System.Drawing.Point(24, 32);
            this.txt_opciones.Name = "txt_opciones";
            this.txt_opciones.Size = new System.Drawing.Size(212, 26);
            this.txt_opciones.TabIndex = 0;
            this.txt_opciones.SelectedIndexChanged += new System.EventHandler(this.txt_opciones_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Location = new System.Drawing.Point(45, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 41);
            this.panel1.TabIndex = 20;
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.BackColor = System.Drawing.Color.Transparent;
            this.txt_total.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(12, 9);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(50, 20);
            this.txt_total.TabIndex = 18;
            this.txt_total.Text = "$0,00";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Gold;
            this.total.Location = new System.Drawing.Point(40, 357);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(136, 26);
            this.total.TabIndex = 18;
            this.total.Text = "Total Importe";
            // 
            // panel_cargaCombustible
            // 
            this.panel_cargaCombustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_cargaCombustible.Controls.Add(this.label3);
            this.panel_cargaCombustible.Controls.Add(this.label1);
            this.panel_cargaCombustible.Controls.Add(this.label5);
            this.panel_cargaCombustible.Controls.Add(this.label8);
            this.panel_cargaCombustible.Controls.Add(this.label9);
            this.panel_cargaCombustible.Controls.Add(this.txt_litros);
            this.panel_cargaCombustible.Controls.Add(this.txt_importe);
            this.panel_cargaCombustible.Controls.Add(this.txt_fecha);
            this.panel_cargaCombustible.Controls.Add(this.label);
            this.panel_cargaCombustible.Controls.Add(this.importe);
            this.panel_cargaCombustible.Controls.Add(this.litros);
            this.panel_cargaCombustible.Controls.Add(this.fecha);
            this.panel_cargaCombustible.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_cargaCombustible.Location = new System.Drawing.Point(28, 110);
            this.panel_cargaCombustible.Name = "panel_cargaCombustible";
            this.panel_cargaCombustible.Size = new System.Drawing.Size(425, 174);
            this.panel_cargaCombustible.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(64, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(64, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(199, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(220, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "son obligatorios";
            // 
            // txt_litros
            // 
            this.txt_litros.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_litros.Location = new System.Drawing.Point(97, 102);
            this.txt_litros.Name = "txt_litros";
            this.txt_litros.Size = new System.Drawing.Size(200, 26);
            this.txt_litros.TabIndex = 17;
            this.txt_litros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(97, 62);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(200, 26);
            this.txt_importe.TabIndex = 16;
            this.txt_importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(97, 21);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(298, 26);
            this.txt_fecha.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.LightGray;
            this.label.Location = new System.Drawing.Point(13, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(188, 20);
            this.label.TabIndex = 66;
            this.label.Text = "Los campos marcados con \r\n";
            // 
            // importe
            // 
            this.importe.AutoSize = true;
            this.importe.BackColor = System.Drawing.Color.Transparent;
            this.importe.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe.ForeColor = System.Drawing.Color.White;
            this.importe.Location = new System.Drawing.Point(13, 68);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(66, 20);
            this.importe.TabIndex = 6;
            this.importe.Text = "Importe";
            // 
            // litros
            // 
            this.litros.AutoSize = true;
            this.litros.BackColor = System.Drawing.Color.Transparent;
            this.litros.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litros.ForeColor = System.Drawing.Color.White;
            this.litros.Location = new System.Drawing.Point(14, 110);
            this.litros.Name = "litros";
            this.litros.Size = new System.Drawing.Size(50, 20);
            this.litros.TabIndex = 5;
            this.litros.Text = "Litros";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(13, 29);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(50, 20);
            this.fecha.TabIndex = 4;
            this.fecha.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cargar combustible";
            // 
            // listadoCombustible
            // 
            this.listadoCombustible.AutoSize = true;
            this.listadoCombustible.BackColor = System.Drawing.Color.Transparent;
            this.listadoCombustible.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoCombustible.ForeColor = System.Drawing.Color.Gold;
            this.listadoCombustible.Location = new System.Drawing.Point(492, 78);
            this.listadoCombustible.Name = "listadoCombustible";
            this.listadoCombustible.Size = new System.Drawing.Size(210, 26);
            this.listadoCombustible.TabIndex = 49;
            this.listadoCombustible.Text = "Listado de combustible";
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.BackColor = System.Drawing.Color.Transparent;
            this.txt_error.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.txt_error.Location = new System.Drawing.Point(242, 82);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(218, 20);
            this.txt_error.TabIndex = 69;
            this.txt_error.Text = "Completar campo/s faltante/s";
            this.txt_error.Visible = false;
            // 
            // datosCombustible
            // 
            this.datosCombustible.AllowUserToAddRows = false;
            this.datosCombustible.AllowUserToDeleteRows = false;
            this.datosCombustible.AllowUserToOrderColumns = true;
            this.datosCombustible.AllowUserToResizeColumns = false;
            this.datosCombustible.AllowUserToResizeRows = false;
            this.datosCombustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datosCombustible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datosCombustible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datosCombustible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datosCombustible.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosCombustible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datosCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datosCombustible.DefaultCellStyle = dataGridViewCellStyle5;
            this.datosCombustible.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datosCombustible.EnableHeadersVisualStyles = false;
            this.datosCombustible.GridColor = System.Drawing.Color.Gold;
            this.datosCombustible.Location = new System.Drawing.Point(474, 110);
            this.datosCombustible.Name = "datosCombustible";
            this.datosCombustible.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosCombustible.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datosCombustible.RowHeadersVisible = false;
            this.datosCombustible.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datosCombustible.RowTemplate.Height = 23;
            this.datosCombustible.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datosCombustible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosCombustible.Size = new System.Drawing.Size(403, 666);
            this.datosCombustible.TabIndex = 70;
            this.datosCombustible.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seleccionar);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.btn_editar.ButtonColor = System.Drawing.Color.Black;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_editar.FlatAppearance.BorderSize = 3;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editar.Location = new System.Drawing.Point(140, 292);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_editar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_editar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_editar.Size = new System.Drawing.Size(98, 32);
            this.btn_editar.TabIndex = 63;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextColor = System.Drawing.Color.White;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_borrar.ButtonColor = System.Drawing.Color.Black;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_borrar.FlatAppearance.BorderSize = 3;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_borrar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_borrar.Location = new System.Drawing.Point(244, 293);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_borrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btn_borrar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_borrar.Size = new System.Drawing.Size(98, 30);
            this.btn_borrar.TabIndex = 64;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.TextColor = System.Drawing.Color.White;
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_cancelar.ButtonColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.BorderSize = 3;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(348, 294);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_cancelar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_cancelar.Size = new System.Drawing.Size(107, 30);
            this.btn_cancelar.TabIndex = 65;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_agregar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_agregar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Location = new System.Drawing.Point(30, 290);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_agregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_agregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_agregar.Size = new System.Drawing.Size(103, 32);
            this.btn_agregar.TabIndex = 62;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextColor = System.Drawing.Color.White;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pb_error
            // 
           
            this.pb_error.Location = new System.Drawing.Point(200, 78);
            this.pb_error.Name = "pb_error";
            this.pb_error.Size = new System.Drawing.Size(29, 26);
            this.pb_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_error.TabIndex = 86;
            this.pb_error.TabStop = false;
            this.pb_error.Visible = false;
            // 
            // FormCombustible
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 831);
            this.Controls.Add(this.pb_error);
            this.Controls.Add(this.datosCombustible);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.total);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.listadoCombustible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.panel_cargaCombustible);
            this.Controls.Add(this.txt_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCombustible";
            this.Text = "Combustible";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_cargaCombustible.ResumeLayout(false);
            this.panel_cargaCombustible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_opciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel panel_cargaCombustible;
        private System.Windows.Forms.TextBox txt_litros;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label importe;
        private System.Windows.Forms.Label litros;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label listadoCombustible;
        private ButtonRedondeado btn_editar;
        private ButtonRedondeado btn_borrar;
        private ButtonRedondeado btn_cancelar;
        private ButtonRedondeado btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txt_error;
        private System.Windows.Forms.DataGridView datosCombustible;
        private System.Windows.Forms.PictureBox pb_error;
    }
}