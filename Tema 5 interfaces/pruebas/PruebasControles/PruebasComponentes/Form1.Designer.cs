namespace PruebasComponentes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSeparacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etiquetaAviso3 = new PruebasControles.EtiquetaAviso();
            this.etiquetaAviso2 = new PruebasControles.EtiquetaAviso();
            this.etiquetaAviso1 = new PruebasControles.EtiquetaAviso();
            this.labelTextbox1 = new PruebasControles.LabelTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Posición";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSeparacion
            // 
            this.txtSeparacion.Location = new System.Drawing.Point(173, 107);
            this.txtSeparacion.Name = "txtSeparacion";
            this.txtSeparacion.Size = new System.Drawing.Size(118, 20);
            this.txtSeparacion.TabIndex = 6;
            this.txtSeparacion.TextChanged += new System.EventHandler(this.txtSeparacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Separación";
            // 
            // etiquetaAviso3
            // 
            this.etiquetaAviso3.ColorPrincipal = System.Drawing.Color.White;
            this.etiquetaAviso3.ColorSecundario = System.Drawing.Color.LightBlue;
            this.etiquetaAviso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso3.Gradiente = true;
            this.etiquetaAviso3.ImagenMarca = "C:\\Users\\David Casalderrey\\Downloads\\logoDave.jpg";
            this.etiquetaAviso3.Location = new System.Drawing.Point(332, 372);
            this.etiquetaAviso3.Marca = PruebasControles.eMarca.Imagen;
            this.etiquetaAviso3.Name = "etiquetaAviso3";
            this.etiquetaAviso3.Size = new System.Drawing.Size(349, 33);
            this.etiquetaAviso3.TabIndex = 4;
            this.etiquetaAviso3.Text = "Esto va a ser una imagen";
            this.etiquetaAviso3.ClickEnMarca += new System.EventHandler(this.etiquetaAviso3_ClickEnMarca);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.ColorPrincipal = System.Drawing.Color.White;
            this.etiquetaAviso2.ColorSecundario = System.Drawing.Color.Olive;
            this.etiquetaAviso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso2.Gradiente = true;
            this.etiquetaAviso2.ImagenMarca = null;
            this.etiquetaAviso2.Location = new System.Drawing.Point(421, 293);
            this.etiquetaAviso2.Marca = PruebasControles.eMarca.Circulo;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(260, 73);
            this.etiquetaAviso2.TabIndex = 3;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            this.etiquetaAviso2.ClickEnMarca += new System.EventHandler(this.etiquetaAviso2_ClickEnMarca);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorPrincipal = System.Drawing.Color.Maroon;
            this.etiquetaAviso1.ColorSecundario = System.Drawing.Color.LightBlue;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.Location = new System.Drawing.Point(448, 259);
            this.etiquetaAviso1.Marca = PruebasControles.eMarca.Cruz;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(233, 28);
            this.etiquetaAviso1.TabIndex = 2;
            this.etiquetaAviso1.Text = "Un aviso importante";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(48, 26);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = PruebasControles.ePosicion.IZQUIERDA;
            this.labelTextbox1.Psw = false;
            this.labelTextbox1.PswChr = '\0';
            this.labelTextbox1.Separacion = 10;
            this.labelTextbox1.Size = new System.Drawing.Size(154, 20);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.TextLbl = "Labelita";
            this.labelTextbox1.TextTxt = "";
            this.labelTextbox1.SeparacionChanged += new System.EventHandler(this.labelTextbox1_SeparacionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeparacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.etiquetaAviso3);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PruebasControles.LabelTextbox labelTextbox1;
        private System.Windows.Forms.Button button1;
        private PruebasControles.EtiquetaAviso etiquetaAviso1;
        private PruebasControles.EtiquetaAviso etiquetaAviso2;
        private PruebasControles.EtiquetaAviso etiquetaAviso3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSeparacion;
        private System.Windows.Forms.Label label1;
    }
}

