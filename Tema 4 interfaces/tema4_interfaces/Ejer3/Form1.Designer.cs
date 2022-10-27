namespace Ejer3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevaImagen = new System.Windows.Forms.Button();
            this.chkModal = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnNuevaImagen
            // 
            this.btnNuevaImagen.Location = new System.Drawing.Point(127, 86);
            this.btnNuevaImagen.Name = "btnNuevaImagen";
            this.btnNuevaImagen.Size = new System.Drawing.Size(96, 23);
            this.btnNuevaImagen.TabIndex = 0;
            this.btnNuevaImagen.Text = "Nueva Imagen";
            this.btnNuevaImagen.UseVisualStyleBackColor = true;
            this.btnNuevaImagen.Click += new System.EventHandler(this.btnNuevaImagen_Click);
            // 
            // chkModal
            // 
            this.chkModal.AutoSize = true;
            this.chkModal.Location = new System.Drawing.Point(140, 152);
            this.chkModal.Name = "chkModal";
            this.chkModal.Size = new System.Drawing.Size(60, 19);
            this.chkModal.TabIndex = 1;
            this.chkModal.Text = "Modal";
            this.chkModal.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Todos los archivos de imagen|*.jpg;*.png;*.gif|JPG (*.jpg)|*jpg|PNG (*.png)|*png" +
    "|GIF (*.gif)|*.gif\" ";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 288);
            this.Controls.Add(this.chkModal);
            this.Controls.Add(this.btnNuevaImagen);
            this.Name = "Form1";
            this.Text = "Ejer3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNuevaImagen;
        private CheckBox chkModal;
        private OpenFileDialog openFileDialog1;
    }
}