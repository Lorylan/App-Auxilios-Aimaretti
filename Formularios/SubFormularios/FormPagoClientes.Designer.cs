namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    partial class FormPagoClientes
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
            this.cliente = new System.Windows.Forms.Label();
            this.txt_Empresa = new System.Windows.Forms.ComboBox();
            this.panel_CargaCliente = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_obs = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_cbu = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_domicilio = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_cuentaBancaria = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_telefono = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cuit = new System.Windows.Forms.Label();
            this.observaciones = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.Label();
            this.cbu = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.domicilio = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.cuentaBancaria = new System.Windows.Forms.Label();
            this.detalle_del_cliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_opciones = new System.Windows.Forms.ComboBox();
            this.opcionPago = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nroComprobante = new System.Windows.Forms.Label();
            this.carga_de_pago = new System.Windows.Forms.Label();
            this.datos_cliente = new System.Windows.Forms.DataGridView();
            this.panel_CargaCliente.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.BackColor = System.Drawing.Color.Transparent;
            this.cliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.White;
            this.cliente.Location = new System.Drawing.Point(408, 9);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(66, 23);
            this.cliente.TabIndex = 64;
            this.cliente.Text = "Cliente:";
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Empresa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empresa.FormattingEnabled = true;
            this.txt_Empresa.Location = new System.Drawing.Point(476, 6);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.Size = new System.Drawing.Size(188, 26);
            this.txt_Empresa.TabIndex = 63;
            this.txt_Empresa.SelectedIndexChanged += new System.EventHandler(this.txt_Empresa_SelectedIndexChanged);
            // 
            // panel_CargaCliente
            // 
            this.panel_CargaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_CargaCliente.Controls.Add(this.panel8);
            this.panel_CargaCliente.Controls.Add(this.panel7);
            this.panel_CargaCliente.Controls.Add(this.panel6);
            this.panel_CargaCliente.Controls.Add(this.panel5);
            this.panel_CargaCliente.Controls.Add(this.panel4);
            this.panel_CargaCliente.Controls.Add(this.panel3);
            this.panel_CargaCliente.Controls.Add(this.panel2);
            this.panel_CargaCliente.Controls.Add(this.observaciones);
            this.panel_CargaCliente.Controls.Add(this.cuit);
            this.panel_CargaCliente.Controls.Add(this.cbu);
            this.panel_CargaCliente.Controls.Add(this.Email);
            this.panel_CargaCliente.Controls.Add(this.domicilio);
            this.panel_CargaCliente.Controls.Add(this.telefono);
            this.panel_CargaCliente.Controls.Add(this.cuentaBancaria);
            this.panel_CargaCliente.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_CargaCliente.Location = new System.Drawing.Point(48, 83);
            this.panel_CargaCliente.Name = "panel_CargaCliente";
            this.panel_CargaCliente.Size = new System.Drawing.Size(942, 128);
            this.panel_CargaCliente.TabIndex = 65;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.txt_obs);
            this.panel8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(138, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(790, 31);
            this.panel8.TabIndex = 72;
            // 
            // txt_obs
            // 
            this.txt_obs.AutoSize = true;
            this.txt_obs.BackColor = System.Drawing.Color.Transparent;
            this.txt_obs.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.ForeColor = System.Drawing.Color.White;
            this.txt_obs.Location = new System.Drawing.Point(6, 6);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(0, 20);
            this.txt_obs.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.txt_cbu);
            this.panel7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(389, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 31);
            this.panel7.TabIndex = 71;
            // 
            // txt_cbu
            // 
            this.txt_cbu.AutoSize = true;
            this.txt_cbu.BackColor = System.Drawing.Color.Transparent;
            this.txt_cbu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cbu.ForeColor = System.Drawing.Color.White;
            this.txt_cbu.Location = new System.Drawing.Point(5, 6);
            this.txt_cbu.Name = "txt_cbu";
            this.txt_cbu.Size = new System.Drawing.Size(0, 20);
            this.txt_cbu.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.txt_domicilio);
            this.panel6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(679, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 31);
            this.panel6.TabIndex = 70;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.AutoSize = true;
            this.txt_domicilio.BackColor = System.Drawing.Color.Transparent;
            this.txt_domicilio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.ForeColor = System.Drawing.Color.White;
            this.txt_domicilio.Location = new System.Drawing.Point(5, 6);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(0, 20);
            this.txt_domicilio.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.txt_cuentaBancaria);
            this.panel5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(138, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 31);
            this.panel5.TabIndex = 68;
            // 
            // txt_cuentaBancaria
            // 
            this.txt_cuentaBancaria.AutoSize = true;
            this.txt_cuentaBancaria.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuentaBancaria.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuentaBancaria.ForeColor = System.Drawing.Color.White;
            this.txt_cuentaBancaria.Location = new System.Drawing.Point(5, 6);
            this.txt_cuentaBancaria.Name = "txt_cuentaBancaria";
            this.txt_cuentaBancaria.Size = new System.Drawing.Size(0, 20);
            this.txt_cuentaBancaria.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.txt_telefono);
            this.panel4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(627, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 31);
            this.panel4.TabIndex = 69;
            // 
            // txt_telefono
            // 
            this.txt_telefono.AutoSize = true;
            this.txt_telefono.BackColor = System.Drawing.Color.Transparent;
            this.txt_telefono.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.White;
            this.txt_telefono.Location = new System.Drawing.Point(3, 6);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(0, 20);
            this.txt_telefono.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(310, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 31);
            this.panel3.TabIndex = 68;
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(5, 6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(0, 20);
            this.txt_email.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txt_cuit);
            this.panel2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(61, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 31);
            this.panel2.TabIndex = 67;
            // 
            // txt_cuit
            // 
            this.txt_cuit.AutoSize = true;
            this.txt_cuit.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.ForeColor = System.Drawing.Color.White;
            this.txt_cuit.Location = new System.Drawing.Point(5, 6);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(0, 20);
            this.txt_cuit.TabIndex = 28;
            // 
            // observaciones
            // 
            this.observaciones.AutoSize = true;
            this.observaciones.BackColor = System.Drawing.Color.Transparent;
            this.observaciones.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observaciones.ForeColor = System.Drawing.Color.White;
            this.observaciones.Location = new System.Drawing.Point(20, 98);
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(114, 20);
            this.observaciones.TabIndex = 26;
            this.observaciones.Text = "Observaciones:";
            // 
            // cuit
            // 
            this.cuit.AutoSize = true;
            this.cuit.BackColor = System.Drawing.Color.Transparent;
            this.cuit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.ForeColor = System.Drawing.Color.White;
            this.cuit.Location = new System.Drawing.Point(14, 19);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(41, 20);
            this.cuit.TabIndex = 20;
            this.cuit.Text = "Cuit:";
            // 
            // cbu
            // 
            this.cbu.AutoSize = true;
            this.cbu.BackColor = System.Drawing.Color.Transparent;
            this.cbu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbu.ForeColor = System.Drawing.Color.White;
            this.cbu.Location = new System.Drawing.Point(341, 61);
            this.cbu.Name = "cbu";
            this.cbu.Size = new System.Drawing.Size(42, 20);
            this.cbu.TabIndex = 25;
            this.cbu.Text = "CBU:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(255, 19);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(49, 20);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email:";
            // 
            // domicilio
            // 
            this.domicilio.AutoSize = true;
            this.domicilio.BackColor = System.Drawing.Color.Transparent;
            this.domicilio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio.ForeColor = System.Drawing.Color.White;
            this.domicilio.Location = new System.Drawing.Point(598, 56);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(75, 20);
            this.domicilio.TabIndex = 21;
            this.domicilio.Text = "Domicilio:";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.BackColor = System.Drawing.Color.Transparent;
            this.telefono.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.ForeColor = System.Drawing.Color.White;
            this.telefono.Location = new System.Drawing.Point(541, 19);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(75, 20);
            this.telefono.TabIndex = 22;
            this.telefono.Text = "Telefono:";
            // 
            // cuentaBancaria
            // 
            this.cuentaBancaria.AutoSize = true;
            this.cuentaBancaria.BackColor = System.Drawing.Color.Transparent;
            this.cuentaBancaria.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaBancaria.ForeColor = System.Drawing.Color.White;
            this.cuentaBancaria.Location = new System.Drawing.Point(7, 59);
            this.cuentaBancaria.Name = "cuentaBancaria";
            this.cuentaBancaria.Size = new System.Drawing.Size(125, 20);
            this.cuentaBancaria.TabIndex = 24;
            this.cuentaBancaria.Text = "Cuenta bancaria:";
            // 
            // detalle_del_cliente
            // 
            this.detalle_del_cliente.AutoSize = true;
            this.detalle_del_cliente.BackColor = System.Drawing.Color.Transparent;
            this.detalle_del_cliente.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle_del_cliente.ForeColor = System.Drawing.Color.Gold;
            this.detalle_del_cliente.Location = new System.Drawing.Point(17, 51);
            this.detalle_del_cliente.Name = "detalle_del_cliente";
            this.detalle_del_cliente.Size = new System.Drawing.Size(201, 29);
            this.detalle_del_cliente.TabIndex = 66;
            this.detalle_del_cliente.Text = "Detalles del cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.txt_opciones);
            this.panel1.Controls.Add(this.opcionPago);
            this.panel1.Controls.Add(this.txt_Fecha);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.nroComprobante);
            this.panel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(48, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 73);
            this.panel1.TabIndex = 66;
            // 
            // txt_opciones
            // 
            this.txt_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_opciones.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_opciones.FormattingEnabled = true;
            this.txt_opciones.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia bancaria"});
            this.txt_opciones.Location = new System.Drawing.Point(512, 30);
            this.txt_opciones.Name = "txt_opciones";
            this.txt_opciones.Size = new System.Drawing.Size(124, 28);
            this.txt_opciones.TabIndex = 56;
            // 
            // opcionPago
            // 
            this.opcionPago.AutoSize = true;
            this.opcionPago.BackColor = System.Drawing.Color.Transparent;
            this.opcionPago.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionPago.ForeColor = System.Drawing.Color.White;
            this.opcionPago.Location = new System.Drawing.Point(509, 9);
            this.opcionPago.Name = "opcionPago";
            this.opcionPago.Size = new System.Drawing.Size(114, 20);
            this.opcionPago.TabIndex = 55;
            this.opcionPago.Text = "Opcion de pago";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.Location = new System.Drawing.Point(223, 29);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(275, 28);
            this.txt_Fecha.TabIndex = 54;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(219, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(50, 20);
            this.fecha.TabIndex = 53;
            this.fecha.Text = "Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(7, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 35;
            // 
            // nroComprobante
            // 
            this.nroComprobante.AutoSize = true;
            this.nroComprobante.BackColor = System.Drawing.Color.Transparent;
            this.nroComprobante.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroComprobante.ForeColor = System.Drawing.Color.White;
            this.nroComprobante.Location = new System.Drawing.Point(3, 9);
            this.nroComprobante.Name = "nroComprobante";
            this.nroComprobante.Size = new System.Drawing.Size(194, 20);
            this.nroComprobante.TabIndex = 16;
            this.nroComprobante.Text = "Comprobante de pago Nro°";
            // 
            // carga_de_pago
            // 
            this.carga_de_pago.AutoSize = true;
            this.carga_de_pago.BackColor = System.Drawing.Color.Transparent;
            this.carga_de_pago.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carga_de_pago.ForeColor = System.Drawing.Color.Gold;
            this.carga_de_pago.Location = new System.Drawing.Point(17, 238);
            this.carga_de_pago.Name = "carga_de_pago";
            this.carga_de_pago.Size = new System.Drawing.Size(149, 29);
            this.carga_de_pago.TabIndex = 67;
            this.carga_de_pago.Text = "Carga de pago";
            // 
            // datos_cliente
            // 
            this.datos_cliente.AllowUserToAddRows = false;
            this.datos_cliente.AllowUserToDeleteRows = false;
            this.datos_cliente.AllowUserToOrderColumns = true;
            this.datos_cliente.AllowUserToResizeColumns = false;
            this.datos_cliente.AllowUserToResizeRows = false;
            this.datos_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datos_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datos_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datos_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datos_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datos_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.datos_cliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datos_cliente.EnableHeadersVisualStyles = false;
            this.datos_cliente.GridColor = System.Drawing.Color.Gold;
            this.datos_cliente.Location = new System.Drawing.Point(792, 299);
            this.datos_cliente.Name = "datos_cliente";
            this.datos_cliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datos_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datos_cliente.RowHeadersVisible = false;
            this.datos_cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datos_cliente.RowTemplate.Height = 23;
            this.datos_cliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_cliente.Size = new System.Drawing.Size(84, 32);
            this.datos_cliente.TabIndex = 71;
            this.datos_cliente.Visible = false;
            // 
            // FormPagoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1018, 817);
            this.Controls.Add(this.datos_cliente);
            this.Controls.Add(this.carga_de_pago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detalle_del_cliente);
            this.Controls.Add(this.panel_CargaCliente);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.txt_Empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPagoClientes";
            this.Text = "FormPagoClientes";
            this.panel_CargaCliente.ResumeLayout(false);
            this.panel_CargaCliente.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.ComboBox txt_Empresa;
        private System.Windows.Forms.Panel panel_CargaCliente;
        private System.Windows.Forms.Label cbu;
        private System.Windows.Forms.Label cuentaBancaria;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label domicilio;
        private System.Windows.Forms.Label cuit;
        private System.Windows.Forms.Label detalle_del_cliente;
        private System.Windows.Forms.Label txt_cuit;
        private System.Windows.Forms.Label observaciones;
        private System.Windows.Forms.Label txt_obs;
        private System.Windows.Forms.Label txt_domicilio;
        private System.Windows.Forms.Label txt_cbu;
        private System.Windows.Forms.Label txt_cuentaBancaria;
        private System.Windows.Forms.Label txt_telefono;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nroComprobante;
        private System.Windows.Forms.Label carga_de_pago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker txt_Fecha;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.ComboBox txt_opciones;
        private System.Windows.Forms.Label opcionPago;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView datos_cliente;
    }
}