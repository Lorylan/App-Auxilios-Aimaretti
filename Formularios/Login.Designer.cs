namespace PuebaDeDiseñoAA
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.line_user = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line_pass = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Redondeo_Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_error = new System.Windows.Forms.Label();
            this.txt_pass_vacio = new System.Windows.Forms.Label();
            this.txt_user_vacio = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.photo_user = new System.Windows.Forms.PictureBox();
            this.photo_lock = new System.Windows.Forms.PictureBox();
            this.button_salir = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.photo_logo = new System.Windows.Forms.PictureBox();
            this.button_acceder = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // line_user
            // 
            this.line_user.BorderColor = System.Drawing.Color.White;
            this.line_user.Name = "line_user";
            this.line_user.X1 = 137;
            this.line_user.X2 = 325;
            this.line_user.Y1 = 343;
            this.line_user.Y2 = 343;
            // 
            // line_pass
            // 
            this.line_pass.BorderColor = System.Drawing.Color.White;
            this.line_pass.Name = "line_pass";
            this.line_pass.X1 = 138;
            this.line_pass.X2 = 325;
            this.line_pass.Y1 = 440;
            this.line_pass.Y2 = 440;
            // 
            // Redondeo_Login
            // 
            this.Redondeo_Login.ElipseRadius = 10;
            this.Redondeo_Login.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PuebaDeDiseñoAA.Properties.Resources.FONDOOOO;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_error);
            this.panel1.Controls.Add(this.txt_pass_vacio);
            this.panel1.Controls.Add(this.txt_user_vacio);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.photo_user);
            this.panel1.Controls.Add(this.photo_lock);
            this.panel1.Controls.Add(this.button_salir);
            this.panel1.Controls.Add(this.photo_logo);
            this.panel1.Controls.Add(this.button_acceder);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 665);
            this.panel1.TabIndex = 0;
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.BackColor = System.Drawing.Color.Transparent;
            this.txt_error.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.txt_error.Location = new System.Drawing.Point(116, 243);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(185, 40);
            this.txt_error.TabIndex = 10;
            this.txt_error.Text = "El usuario y/o contraseña\r\nson incorrectos\r\n";
            this.txt_error.Visible = false;
            // 
            // txt_pass_vacio
            // 
            this.txt_pass_vacio.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass_vacio.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_vacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.txt_pass_vacio.Location = new System.Drawing.Point(134, 451);
            this.txt_pass_vacio.Name = "txt_pass_vacio";
            this.txt_pass_vacio.Size = new System.Drawing.Size(194, 25);
            this.txt_pass_vacio.TabIndex = 0;
            this.txt_pass_vacio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_user_vacio
            // 
            this.txt_user_vacio.BackColor = System.Drawing.Color.Transparent;
            this.txt_user_vacio.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_vacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.txt_user_vacio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_user_vacio.Location = new System.Drawing.Point(134, 352);
            this.txt_user_vacio.Margin = new System.Windows.Forms.Padding(0);
            this.txt_user_vacio.Name = "txt_user_vacio";
            this.txt_user_vacio.Size = new System.Drawing.Size(187, 20);
            this.txt_user_vacio.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Black;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.Location = new System.Drawing.Point(174, 408);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(146, 21);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "CONTRASEÑA";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Black;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_user.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_user.Location = new System.Drawing.Point(171, 310);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(145, 21);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "USUARIO";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // photo_user
            // 
            this.photo_user.BackColor = System.Drawing.Color.Transparent;
            this.photo_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo_user.Image = global::PuebaDeDiseñoAA.Properties.Resources.user;
            this.photo_user.Location = new System.Drawing.Point(137, 303);
            this.photo_user.Name = "photo_user";
            this.photo_user.Size = new System.Drawing.Size(28, 28);
            this.photo_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_user.TabIndex = 4;
            this.photo_user.TabStop = false;
            // 
            // photo_lock
            // 
            this.photo_lock.BackColor = System.Drawing.Color.Transparent;
            this.photo_lock.Image = global::PuebaDeDiseñoAA.Properties.Resources._lock;
            this.photo_lock.Location = new System.Drawing.Point(137, 399);
            this.photo_lock.Name = "photo_lock";
            this.photo_lock.Size = new System.Drawing.Size(28, 30);
            this.photo_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_lock.TabIndex = 5;
            this.photo_lock.TabStop = false;
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.Transparent;
            this.button_salir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.button_salir.ButtonColor = System.Drawing.Color.Black;
            this.button_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_salir.FlatAppearance.BorderSize = 3;
            this.button_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.button_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.button_salir.ForeColor = System.Drawing.Color.Transparent;
            this.button_salir.Location = new System.Drawing.Point(158, 561);
            this.button_salir.Name = "button_salir";
            this.button_salir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.button_salir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.button_salir.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_salir.Size = new System.Drawing.Size(132, 32);
            this.button_salir.TabIndex = 6;
            this.button_salir.Text = "SALIR";
            this.button_salir.TextColor = System.Drawing.Color.White;
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // photo_logo
            // 
            this.photo_logo.Image = global::PuebaDeDiseñoAA.Properties.Resources.WhatsApp_Image_2020_06_15_at_9_13_14_AM;
            this.photo_logo.Location = new System.Drawing.Point(120, 27);
            this.photo_logo.Name = "photo_logo";
            this.photo_logo.Size = new System.Drawing.Size(200, 173);
            this.photo_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_logo.TabIndex = 7;
            this.photo_logo.TabStop = false;
            // 
            // button_acceder
            // 
            this.button_acceder.BackColor = System.Drawing.Color.Transparent;
            this.button_acceder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.button_acceder.ButtonColor = System.Drawing.Color.Black;
            this.button_acceder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_acceder.FlatAppearance.BorderSize = 3;
            this.button_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.button_acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_acceder.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.button_acceder.ForeColor = System.Drawing.Color.Transparent;
            this.button_acceder.Location = new System.Drawing.Point(138, 492);
            this.button_acceder.Name = "button_acceder";
            this.button_acceder.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.button_acceder.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_acceder.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_acceder.Size = new System.Drawing.Size(175, 46);
            this.button_acceder.TabIndex = 8;
            this.button_acceder.Text = "ACCEDER";
            this.button_acceder.TextColor = System.Drawing.Color.White;
            this.button_acceder.UseVisualStyleBackColor = false;
            this.button_acceder.Click += new System.EventHandler(this.button_acceder_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.line_user,
            this.line_pass});
            this.shapeContainer1.Size = new System.Drawing.Size(450, 665);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 665);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox photo_logo;
        private ButtonRedondeado button_acceder;
        private ButtonRedondeado button_salir;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line_user;
        private Microsoft.VisualBasic.PowerPacks.LineShape line_pass;
        private System.Windows.Forms.PictureBox photo_user;
        private System.Windows.Forms.PictureBox photo_lock;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label txt_pass_vacio;
        private System.Windows.Forms.Label txt_user_vacio;
        private Bunifu.Framework.UI.BunifuElipse Redondeo_Login;
        private System.Windows.Forms.Label txt_error;
    }
}

