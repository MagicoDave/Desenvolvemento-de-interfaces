namespace ejer2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelServer = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServer
            // 
            this.panelServer.Controls.Add(this.lblSection);
            this.panelServer.Controls.Add(this.txtIP);
            this.panelServer.Controls.Add(this.txtPort);
            this.panelServer.Controls.Add(this.lblPort);
            this.panelServer.Controls.Add(this.lblIP);
            this.panelServer.Location = new System.Drawing.Point(12, 12);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(238, 77);
            this.panelServer.TabIndex = 11;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(15, -3);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(39, 15);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Server";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(38, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(192, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.20.100";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(38, 47);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(192, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "5001";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 50);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(15, 21);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 15);
            this.lblIP.TabIndex = 8;
            this.lblIP.Text = "IP";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(91, 95);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 126);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Conect to...";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelServer;
        private Label lblSection;
        private TextBox txtIP;
        private TextBox txtPort;
        private Label lblPort;
        private Label lblIP;
        private Button btnGuardar;
    }
}