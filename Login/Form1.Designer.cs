﻿namespace Login
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAcep = new System.Windows.Forms.Button();
            this.TxtboxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // BtnAcep
            // 
            this.BtnAcep.Location = new System.Drawing.Point(104, 217);
            this.BtnAcep.Name = "BtnAcep";
            this.BtnAcep.Size = new System.Drawing.Size(75, 23);
            this.BtnAcep.TabIndex = 3;
            this.BtnAcep.Text = "Aceptar";
            this.BtnAcep.UseVisualStyleBackColor = true;
            this.BtnAcep.Click += new System.EventHandler(this.BtnAcep_Click);
            // 
            // TxtboxUsuario
            // 
            this.TxtboxUsuario.Location = new System.Drawing.Point(92, 80);
            this.TxtboxUsuario.Name = "TxtboxUsuario";
            this.TxtboxUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtboxUsuario.TabIndex = 1;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(92, 160);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.PasswordChar = '*';
            this.textBoxContra.Size = new System.Drawing.Size(100, 20);
            this.textBoxContra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.TxtboxUsuario);
            this.Controls.Add(this.BtnAcep);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAcep;
        private System.Windows.Forms.TextBox TxtboxUsuario;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.Label label2;
    }
}

