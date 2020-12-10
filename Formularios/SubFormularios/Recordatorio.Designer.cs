namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    partial class Recordatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmacion = new System.Windows.Forms.Label();
            this.btn_confirmar = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.txt_pagos_hoy = new System.Windows.Forms.Label();
            this.txt_pagos_recordatorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_confirmacion);
            this.panel1.Controls.Add(this.btn_confirmar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_datos);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 518);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Recordatorio de pago/s de clientes:";
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.AutoSize = true;
            this.txt_confirmacion.BackColor = System.Drawing.Color.Transparent;
            this.txt_confirmacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmacion.ForeColor = System.Drawing.Color.White;
            this.txt_confirmacion.Location = new System.Drawing.Point(35, 39);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.Size = new System.Drawing.Size(335, 23);
            this.txt_confirmacion.TabIndex = 82;
            this.txt_confirmacion.Text = "Pago/s de clientes que se pueden cobrar hoy:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(0)))));
            this.btn_confirmar.ButtonColor = System.Drawing.Color.Black;
            this.btn_confirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_confirmar.FlatAppearance.BorderSize = 3;
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_confirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.Location = new System.Drawing.Point(332, 445);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_confirmar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_confirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_confirmar.Size = new System.Drawing.Size(98, 40);
            this.btn_confirmar.TabIndex = 81;
            this.btn_confirmar.Text = "Ok";
            this.btn_confirmar.TextColor = System.Drawing.Color.White;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.txt_pagos_recordatorio);
            this.panel2.ForeColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(39, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 128);
            this.panel2.TabIndex = 80;
            // 
            // panel_datos
            // 
            this.panel_datos.AutoScroll = true;
            this.panel_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_datos.Controls.Add(this.txt_pagos_hoy);
            this.panel_datos.ForeColor = System.Drawing.Color.LightGray;
            this.panel_datos.Location = new System.Drawing.Point(39, 65);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(632, 138);
            this.panel_datos.TabIndex = 80;
            // 
            // txt_pagos_hoy
            // 
            this.txt_pagos_hoy.AutoSize = true;
            this.txt_pagos_hoy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_pagos_hoy.Location = new System.Drawing.Point(16, 19);
            this.txt_pagos_hoy.Name = "txt_pagos_hoy";
            this.txt_pagos_hoy.Size = new System.Drawing.Size(0, 23);
            this.txt_pagos_hoy.TabIndex = 0;
            // 
            // txt_pagos_recordatorio
            // 
            this.txt_pagos_recordatorio.AutoSize = true;
            this.txt_pagos_recordatorio.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_pagos_recordatorio.Location = new System.Drawing.Point(16, 13);
            this.txt_pagos_recordatorio.Name = "txt_pagos_recordatorio";
            this.txt_pagos_recordatorio.Size = new System.Drawing.Size(0, 23);
            this.txt_pagos_recordatorio.TabIndex = 1;
            // 
            // Recordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recordatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_datos;
        private ButtonRedondeado btn_confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_confirmacion;
        private System.Windows.Forms.Label txt_pagos_recordatorio;
        private System.Windows.Forms.Label txt_pagos_hoy;
    }
}