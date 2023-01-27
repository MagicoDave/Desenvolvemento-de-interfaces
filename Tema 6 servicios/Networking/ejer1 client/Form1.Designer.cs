namespace ejer1_client
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
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.panelServer = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.panelServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(12, 95);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(93, 95);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(174, 95);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.ButtonClick);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(93, 125);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(156, 23);
            this.txtPw.TabIndex = 4;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 172);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(145, 15);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "PUSH A BUTTON NOW!!!1!";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(38, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(192, 23);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(38, 47);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(192, 23);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "31416";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox_TextChanged);
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
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 50);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port";
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
            this.panelServer.TabIndex = 10;
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
            // Form1
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 202);
            this.Controls.Add(this.panelServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnTime);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTime;
        private Button btnDate;
        private Button btnAll;
        private Button btnClose;
        private TextBox txtPw;
        private Label lblServer;
        private TextBox txtIP;
        private TextBox txtPort;
        private Label lblIP;
        private Label lblPort;
        private Panel panelServer;
        private Label lblSection;
    }
}