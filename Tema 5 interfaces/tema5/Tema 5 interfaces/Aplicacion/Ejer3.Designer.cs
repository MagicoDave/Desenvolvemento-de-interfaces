﻿namespace Aplicacion
{
    partial class Ejer3
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.smpControl = new Tema_5_interfaces.SimpleMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(753, 475);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(101, 23);
            this.btnDirectory.TabIndex = 1;
            this.btnDirectory.Text = "Abrir directorio...";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // pbDisplay
            // 
            this.pbDisplay.Location = new System.Drawing.Point(13, 13);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(841, 433);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplay.TabIndex = 2;
            this.pbDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // smpControl
            // 
            this.smpControl.Location = new System.Drawing.Point(12, 452);
            this.smpControl.MM = 0;
            this.smpControl.Name = "smpControl";
            this.smpControl.Size = new System.Drawing.Size(135, 66);
            this.smpControl.SS = 0;
            this.smpControl.TabIndex = 3;
            this.smpControl.PlayClick += new System.EventHandler(this.smpControl_PlayClick);
            // 
            // Ejer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 530);
            this.Controls.Add(this.smpControl);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.btnDirectory);
            this.Name = "Ejer3";
            this.Text = "Ejercicio 3";
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.PictureBox pbDisplay;
        private Tema_5_interfaces.SimpleMediaPlayer smpControl;
        private System.Windows.Forms.Timer timer1;
    }
}

