namespace Ejer5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnMoverDerecha = new System.Windows.Forms.Button();
            this.btnMoverIzquierda = new System.Windows.Forms.Button();
            this.lblCantidadElementos = new System.Windows.Forms.Label();
            this.lblIndicesSeleccionados = new System.Windows.Forms.Label();
            this.txtAnadir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(326, 334);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(425, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(326, 334);
            this.listBox2.TabIndex = 1;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(12, 415);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(93, 415);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnMoverDerecha
            // 
            this.btnMoverDerecha.Location = new System.Drawing.Point(344, 150);
            this.btnMoverDerecha.Name = "btnMoverDerecha";
            this.btnMoverDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnMoverDerecha.TabIndex = 4;
            this.btnMoverDerecha.Text = "-->";
            this.btnMoverDerecha.UseVisualStyleBackColor = true;
            this.btnMoverDerecha.Click += new System.EventHandler(this.btnMoverDerecha_Click);
            // 
            // btnMoverIzquierda
            // 
            this.btnMoverIzquierda.Location = new System.Drawing.Point(344, 179);
            this.btnMoverIzquierda.Name = "btnMoverIzquierda";
            this.btnMoverIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnMoverIzquierda.TabIndex = 5;
            this.btnMoverIzquierda.Text = "<--";
            this.btnMoverIzquierda.UseVisualStyleBackColor = true;
            this.btnMoverIzquierda.Click += new System.EventHandler(this.btnMoverIzquierda_Click);
            // 
            // lblCantidadElementos
            // 
            this.lblCantidadElementos.AutoSize = true;
            this.lblCantidadElementos.Location = new System.Drawing.Point(12, 9);
            this.lblCantidadElementos.Name = "lblCantidadElementos";
            this.lblCantidadElementos.Size = new System.Drawing.Size(68, 15);
            this.lblCantidadElementos.TabIndex = 6;
            this.lblCantidadElementos.Text = "Elementos: ";
            // 
            // lblIndicesSeleccionados
            // 
            this.lblIndicesSeleccionados.AutoSize = true;
            this.lblIndicesSeleccionados.Location = new System.Drawing.Point(130, 9);
            this.lblIndicesSeleccionados.Name = "lblIndicesSeleccionados";
            this.lblIndicesSeleccionados.Size = new System.Drawing.Size(50, 15);
            this.lblIndicesSeleccionados.TabIndex = 7;
            this.lblIndicesSeleccionados.Text = "Indices: ";
            // 
            // txtAnadir
            // 
            this.txtAnadir.Location = new System.Drawing.Point(12, 386);
            this.txtAnadir.Name = "txtAnadir";
            this.txtAnadir.Size = new System.Drawing.Size(326, 23);
            this.txtAnadir.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.txtAnadir);
            this.Controls.Add(this.lblIndicesSeleccionados);
            this.Controls.Add(this.lblCantidadElementos);
            this.Controls.Add(this.btnMoverIzquierda);
            this.Controls.Add(this.btnMoverDerecha);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAnadir;
        private Button btnQuitar;
        private Button btnMoverDerecha;
        private Button btnMoverIzquierda;
        private Label lblCantidadElementos;
        private Label lblIndicesSeleccionados;
        private TextBox txtAnadir;
    }
}