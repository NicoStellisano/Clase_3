﻿namespace Pelotitas_4
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnRenaudar = new System.Windows.Forms.Button();
            this.btnDestruir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(0, 254);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(0, 283);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnRenaudar
            // 
            this.btnRenaudar.Location = new System.Drawing.Point(97, 254);
            this.btnRenaudar.Name = "btnRenaudar";
            this.btnRenaudar.Size = new System.Drawing.Size(75, 23);
            this.btnRenaudar.TabIndex = 3;
            this.btnRenaudar.Text = "Renaudar";
            this.btnRenaudar.UseVisualStyleBackColor = true;
            this.btnRenaudar.Click += new System.EventHandler(this.btnRenaudar_Click);
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(97, 283);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(75, 23);
            this.btnDestruir.TabIndex = 4;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.btnRenaudar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnRenaudar;
        private System.Windows.Forms.Button btnDestruir;
    }
}

