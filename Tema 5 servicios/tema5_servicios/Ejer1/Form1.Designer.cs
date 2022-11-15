namespace Ejer1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCambiarDirectorio = new System.Windows.Forms.Button();
            this.listBoxDirectorios = new System.Windows.Forms.ListBox();
            this.listBoxArchivos = new System.Windows.Forms.ListBox();
            this.lblSubdirectorios = new System.Windows.Forms.Label();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblTamanoArchivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 491);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Escriba una dirección local...";
            this.txtDireccion.Size = new System.Drawing.Size(701, 23);
            this.txtDireccion.TabIndex = 0;
            // 
            // btnCambiarDirectorio
            // 
            this.btnCambiarDirectorio.Location = new System.Drawing.Point(719, 477);
            this.btnCambiarDirectorio.Name = "btnCambiarDirectorio";
            this.btnCambiarDirectorio.Size = new System.Drawing.Size(69, 48);
            this.btnCambiarDirectorio.TabIndex = 1;
            this.btnCambiarDirectorio.Text = "Cambiar directorio";
            this.btnCambiarDirectorio.UseVisualStyleBackColor = true;
            this.btnCambiarDirectorio.Click += new System.EventHandler(this.btnCambiarDirectorio_Click);
            // 
            // listBoxDirectorios
            // 
            this.listBoxDirectorios.FormattingEnabled = true;
            this.listBoxDirectorios.ItemHeight = 15;
            this.listBoxDirectorios.Location = new System.Drawing.Point(12, 40);
            this.listBoxDirectorios.Name = "listBoxDirectorios";
            this.listBoxDirectorios.Size = new System.Drawing.Size(389, 424);
            this.listBoxDirectorios.TabIndex = 2;
            this.listBoxDirectorios.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectorios_SelectedIndexChanged);
            // 
            // listBoxArchivos
            // 
            this.listBoxArchivos.FormattingEnabled = true;
            this.listBoxArchivos.ItemHeight = 15;
            this.listBoxArchivos.Location = new System.Drawing.Point(407, 40);
            this.listBoxArchivos.Name = "listBoxArchivos";
            this.listBoxArchivos.Size = new System.Drawing.Size(381, 424);
            this.listBoxArchivos.TabIndex = 3;
            this.listBoxArchivos.SelectedIndexChanged += new System.EventHandler(this.listBoxArchivos_SelectedIndexChanged);
            this.listBoxArchivos.DoubleClick += new System.EventHandler(this.listBoxArchivos_DoubleClick);
            // 
            // lblSubdirectorios
            // 
            this.lblSubdirectorios.AutoSize = true;
            this.lblSubdirectorios.Location = new System.Drawing.Point(14, 3);
            this.lblSubdirectorios.Name = "lblSubdirectorios";
            this.lblSubdirectorios.Size = new System.Drawing.Size(83, 15);
            this.lblSubdirectorios.TabIndex = 4;
            this.lblSubdirectorios.Text = "Subdirectorios";
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(407, 1);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(53, 15);
            this.lblArchivos.TabIndex = 5;
            this.lblArchivos.Text = "Archivos";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(407, 19);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(60, 15);
            this.lblNombreArchivo.TabIndex = 6;
            this.lblNombreArchivo.Text = "Nombre:  ";
            // 
            // lblTamanoArchivo
            // 
            this.lblTamanoArchivo.AutoSize = true;
            this.lblTamanoArchivo.Location = new System.Drawing.Point(606, 19);
            this.lblTamanoArchivo.Name = "lblTamanoArchivo";
            this.lblTamanoArchivo.Size = new System.Drawing.Size(55, 15);
            this.lblTamanoArchivo.TabIndex = 7;
            this.lblTamanoArchivo.Text = "Tamaño: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCambiarDirectorio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.lblTamanoArchivo);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.lblSubdirectorios);
            this.Controls.Add(this.listBoxArchivos);
            this.Controls.Add(this.listBoxDirectorios);
            this.Controls.Add(this.btnCambiarDirectorio);
            this.Controls.Add(this.txtDireccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador de sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDireccion;
        private Button btnCambiarDirectorio;
        private ListBox listBoxDirectorios;
        private ListBox listBoxArchivos;
        private Label lblSubdirectorios;
        private Label lblArchivos;
        private Label lblNombreArchivo;
        private Label lblTamanoArchivo;
    }
}