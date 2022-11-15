namespace Ejer2
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
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkMayus = new System.Windows.Forms.CheckBox();
            this.txtExtensiones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(12, 415);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.PlaceholderText = "Escriba una dirección local...";
            this.txtDirectorio.Size = new System.Drawing.Size(533, 23);
            this.txtDirectorio.TabIndex = 2;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(12, 10);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.PlaceholderText = "Escriba una cadena...";
            this.txtCadena.Size = new System.Drawing.Size(591, 23);
            this.txtCadena.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 364);
            this.listBox1.TabIndex = 3;
            this.listBox1.TabStop = false;
            // 
            // chkMayus
            // 
            this.chkMayus.AutoSize = true;
            this.chkMayus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMayus.Location = new System.Drawing.Point(609, 15);
            this.chkMayus.Name = "chkMayus";
            this.chkMayus.Size = new System.Drawing.Size(98, 19);
            this.chkMayus.TabIndex = 1;
            this.chkMayus.Text = "¿Mayúsculas?";
            this.chkMayus.UseVisualStyleBackColor = true;
            // 
            // txtExtensiones
            // 
            this.txtExtensiones.Location = new System.Drawing.Point(551, 415);
            this.txtExtensiones.Name = "txtExtensiones";
            this.txtExtensiones.PlaceholderText = "Escriba extensiones separadas por coma...";
            this.txtExtensiones.Size = new System.Drawing.Size(237, 23);
            this.txtExtensiones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExtensiones);
            this.Controls.Add(this.chkMayus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtDirectorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Buscador de cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDirectorio;
        private TextBox txtCadena;
        private Button btnBuscar;
        private ListBox listBox1;
        private CheckBox chkMayus;
        private TextBox txtExtensiones;
    }
}