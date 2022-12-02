namespace Ejer8
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(254, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.InitialDirectory = "%homepath%";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 378);
            this.panel1.TabIndex = 1;
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Enabled = false;
            this.btnRetroceso.Location = new System.Drawing.Point(173, 12);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceso.TabIndex = 0;
            this.btnRetroceso.Text = "Retroceder";
            this.btnRetroceso.UseVisualStyleBackColor = true;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Enabled = false;
            this.btnAvanzar.Location = new System.Drawing.Point(335, 12);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(12, 38);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(68, 15);
            this.lblDirectorio.TabIndex = 3;
            this.lblDirectorio.Text = "Directorio:  ";
            this.lblDirectorio.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 437);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.Visible = false;
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(439, 437);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(55, 15);
            this.lblTamano.TabIndex = 5;
            this.lblTamano.Text = "Tamaño: ";
            this.lblTamano.Visible = false;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(254, 437);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(71, 15);
            this.lblResolucion.TabIndex = 6;
            this.lblResolucion.Text = "Resolución: ";
            this.lblResolucion.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAbrir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrir;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private Button btnRetroceso;
        private Button btnAvanzar;
        private Label lblDirectorio;
        private Label lblNombre;
        private Label lblTamano;
        private Label lblResolucion;
    }
}