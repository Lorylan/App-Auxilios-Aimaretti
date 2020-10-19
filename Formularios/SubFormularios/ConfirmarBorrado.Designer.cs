using PuebaDeDiseñoAA.Clases;

namespace PuebaDeDiseñoAA.Formularios.SubFormularios
{
    
    partial class ConfirmarBorrado
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
            this.btn_confirmar = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.btn_cancelar = new PuebaDeDiseñoAA.ButtonRedondeado();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.txt_dato1 = new System.Windows.Forms.Label();
            this.txt_dato2 = new System.Windows.Forms.Label();
            this.txt_confirmacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_confirmar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.panel_datos);
            this.panel1.Controls.Add(this.txt_confirmacion);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 240);
            this.panel1.TabIndex = 0;
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
            this.btn_confirmar.Location = new System.Drawing.Point(108, 179);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btn_confirmar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_confirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_confirmar.Size = new System.Drawing.Size(123, 32);
            this.btn_confirmar.TabIndex = 80;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextColor = System.Drawing.Color.White;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_cancelar.ButtonColor = System.Drawing.Color.Black;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.BorderSize = 3;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(255, 179);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btn_cancelar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_cancelar.Size = new System.Drawing.Size(129, 30);
            this.btn_cancelar.TabIndex = 81;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // panel_datos
            // 
            this.panel_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_datos.Controls.Add(this.txt_dato1);
            this.panel_datos.Controls.Add(this.txt_dato2);
            this.panel_datos.ForeColor = System.Drawing.Color.LightGray;
            this.panel_datos.Location = new System.Drawing.Point(85, 49);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(351, 107);
            this.panel_datos.TabIndex = 79;
            // 
            // txt_dato1
            // 
            this.txt_dato1.AutoSize = true;
            this.txt_dato1.BackColor = System.Drawing.Color.Transparent;
            this.txt_dato1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_dato1.ForeColor = System.Drawing.Color.White;
            this.txt_dato1.Location = new System.Drawing.Point(20, 23);
            this.txt_dato1.Name = "txt_dato1";
            this.txt_dato1.Size = new System.Drawing.Size(68, 20);
            this.txt_dato1.TabIndex = 61;
            this.txt_dato1.Text = "Nombre:";
            // 
            // txt_dato2
            // 
            this.txt_dato2.AutoSize = true;
            this.txt_dato2.BackColor = System.Drawing.Color.Transparent;
            this.txt_dato2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.txt_dato2.ForeColor = System.Drawing.Color.White;
            this.txt_dato2.Location = new System.Drawing.Point(20, 55);
            this.txt_dato2.Name = "txt_dato2";
            this.txt_dato2.Size = new System.Drawing.Size(69, 20);
            this.txt_dato2.TabIndex = 62;
            this.txt_dato2.Text = "Apellido:";
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.AutoSize = true;
            this.txt_confirmacion.BackColor = System.Drawing.Color.Transparent;
            this.txt_confirmacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmacion.ForeColor = System.Drawing.Color.White;
            this.txt_confirmacion.Location = new System.Drawing.Point(15, 14);
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.Size = new System.Drawing.Size(472, 23);
            this.txt_confirmacion.TabIndex = 78;
            this.txt_confirmacion.Text = "¿Esta seguro que desea eliminar la fila con los siguientes datos?";
            // 
            // ConfirmarBorrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 246);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmarBorrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmarBorrado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Label txt_confirmacion;
        private ButtonRedondeado btn_confirmar;
        private ButtonRedondeado btn_cancelar;
        private System.Windows.Forms.Label txt_dato1;
        private System.Windows.Forms.Label txt_dato2;
    }
}