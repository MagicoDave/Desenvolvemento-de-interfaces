namespace Ejer7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboxAlumno = new System.Windows.Forms.ComboBox();
            this.cboxAsignatura = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMediaTabla = new System.Windows.Forms.Label();
            this.lblMediaAlumno = new System.Windows.Forms.Label();
            this.lblMediaAsignatura = new System.Windows.Forms.Label();
            this.lblNotaMaxima = new System.Windows.Forms.Label();
            this.lblNotaMinima = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cboxAlumno
            // 
            this.cboxAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAlumno.DropDownWidth = 300;
            this.cboxAlumno.FormattingEnabled = true;
            this.cboxAlumno.Location = new System.Drawing.Point(66, 6);
            this.cboxAlumno.Name = "cboxAlumno";
            this.cboxAlumno.Size = new System.Drawing.Size(300, 23);
            this.cboxAlumno.TabIndex = 0;
            this.cboxAlumno.SelectedIndexChanged += new System.EventHandler(this.cboxAlumno_SelectedIndexChanged);
            // 
            // cboxAsignatura
            // 
            this.cboxAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAsignatura.DropDownWidth = 300;
            this.cboxAsignatura.FormattingEnabled = true;
            this.cboxAsignatura.Location = new System.Drawing.Point(488, 6);
            this.cboxAsignatura.Name = "cboxAsignatura";
            this.cboxAsignatura.Size = new System.Drawing.Size(300, 23);
            this.cboxAsignatura.TabIndex = 1;
            this.cboxAsignatura.SelectedIndexChanged += new System.EventHandler(this.cboxAsignatura_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 388);
            this.panel1.TabIndex = 2;
            // 
            // lblMediaTabla
            // 
            this.lblMediaTabla.AutoSize = true;
            this.lblMediaTabla.Location = new System.Drawing.Point(648, 32);
            this.lblMediaTabla.Name = "lblMediaTabla";
            this.lblMediaTabla.Size = new System.Drawing.Size(103, 15);
            this.lblMediaTabla.TabIndex = 3;
            this.lblMediaTabla.Text = "Media de la tabla: ";
            // 
            // lblMediaAlumno
            // 
            this.lblMediaAlumno.AutoSize = true;
            this.lblMediaAlumno.Location = new System.Drawing.Point(320, 32);
            this.lblMediaAlumno.Name = "lblMediaAlumno";
            this.lblMediaAlumno.Size = new System.Drawing.Size(109, 15);
            this.lblMediaAlumno.TabIndex = 4;
            this.lblMediaAlumno.Text = "Media del alumno: ";
            // 
            // lblMediaAsignatura
            // 
            this.lblMediaAsignatura.AutoSize = true;
            this.lblMediaAsignatura.Location = new System.Drawing.Point(471, 32);
            this.lblMediaAsignatura.Name = "lblMediaAsignatura";
            this.lblMediaAsignatura.Size = new System.Drawing.Size(132, 15);
            this.lblMediaAsignatura.TabIndex = 5;
            this.lblMediaAsignatura.Text = "Media de la asignatura: ";
            // 
            // lblNotaMaxima
            // 
            this.lblNotaMaxima.AutoSize = true;
            this.lblNotaMaxima.Location = new System.Drawing.Point(12, 32);
            this.lblNotaMaxima.Name = "lblNotaMaxima";
            this.lblNotaMaxima.Size = new System.Drawing.Size(85, 15);
            this.lblNotaMaxima.TabIndex = 6;
            this.lblNotaMaxima.Text = "Nota máxima: ";
            // 
            // lblNotaMinima
            // 
            this.lblNotaMinima.AutoSize = true;
            this.lblNotaMinima.Location = new System.Drawing.Point(168, 32);
            this.lblNotaMinima.Name = "lblNotaMinima";
            this.lblNotaMinima.Size = new System.Drawing.Size(83, 15);
            this.lblNotaMinima.TabIndex = 7;
            this.lblNotaMinima.Text = "Nota mínima: ";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(56, 15);
            this.lblAlumnos.TabIndex = 8;
            this.lblAlumnos.Text = "Alumno: ";
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Location = new System.Drawing.Point(415, 9);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(67, 15);
            this.lblAsignaturas.TabIndex = 9;
            this.lblAsignaturas.Text = "Asignatura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lblNotaMinima);
            this.Controls.Add(this.lblNotaMaxima);
            this.Controls.Add(this.lblMediaAsignatura);
            this.Controls.Add(this.lblMediaAlumno);
            this.Controls.Add(this.lblMediaTabla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxAsignatura);
            this.Controls.Add(this.cboxAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxAlumno;
        private ComboBox cboxAsignatura;
        private Panel panel1;
        private Label lblMediaTabla;
        private Label lblMediaAlumno;
        private Label lblMediaAsignatura;
        private Label lblNotaMaxima;
        private Label lblNotaMinima;
        private Label lblAlumnos;
        private Label lblAsignaturas;
        private ToolTip toolTip1;
    }
}