namespace Aplicacion
{
    partial class FormAhorcado
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
            this.ahorcado = new Tema_5_interfaces.DibujoAhorcado();
            this.txtAhorcado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ahorcado
            // 
            this.ahorcado.Errores = 0;
            this.ahorcado.Location = new System.Drawing.Point(12, 12);
            this.ahorcado.Name = "ahorcado";
            this.ahorcado.Size = new System.Drawing.Size(302, 307);
            this.ahorcado.TabIndex = 0;
            this.ahorcado.Text = "dibujoAhorcado1";
            this.ahorcado.Ahorcado += new System.EventHandler(this.ahorcado_Ahorcado);
            // 
            // txtAhorcado
            // 
            this.txtAhorcado.Location = new System.Drawing.Point(210, 299);
            this.txtAhorcado.Name = "txtAhorcado";
            this.txtAhorcado.Size = new System.Drawing.Size(172, 20);
            this.txtAhorcado.TabIndex = 1;
            this.txtAhorcado.TextChanged += new System.EventHandler(this.txtAhorcado_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(340, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "SUPERCORBATA";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(388, 299);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormAhorcado
            // 
            this.AcceptButton = this.btnValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 344);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtAhorcado);
            this.Controls.Add(this.ahorcado);
            this.Name = "FormAhorcado";
            this.Text = "FormAhorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tema_5_interfaces.DibujoAhorcado ahorcado;
        private System.Windows.Forms.TextBox txtAhorcado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnValidar;
    }
}