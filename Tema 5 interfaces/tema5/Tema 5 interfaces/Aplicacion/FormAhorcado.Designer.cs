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
            this.dibujoAhorcado1 = new Tema_5_interfaces.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 10;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(12, 12);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(302, 307);
            this.dibujoAhorcado1.TabIndex = 0;
            this.dibujoAhorcado1.Text = "dibujoAhorcado1";
            // 
            // FormAhorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 497);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Name = "FormAhorcado";
            this.Text = "FormAhorcado";
            this.ResumeLayout(false);

        }

        #endregion

        private Tema_5_interfaces.DibujoAhorcado dibujoAhorcado1;
    }
}