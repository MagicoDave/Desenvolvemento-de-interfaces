namespace ejer3
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
            this.btnViewProcesses = new System.Windows.Forms.Button();
            this.btnProcessInfo = new System.Windows.Forms.Button();
            this.btnCloseProcess = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.btnRunApp = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnViewProcesses
            // 
            this.btnViewProcesses.Location = new System.Drawing.Point(12, 12);
            this.btnViewProcesses.Name = "btnViewProcesses";
            this.btnViewProcesses.Size = new System.Drawing.Size(100, 23);
            this.btnViewProcesses.TabIndex = 0;
            this.btnViewProcesses.Text = "View Processes";
            this.btnViewProcesses.UseVisualStyleBackColor = true;
            this.btnViewProcesses.Click += new System.EventHandler(this.btnViewProcesses_Click);
            // 
            // btnProcessInfo
            // 
            this.btnProcessInfo.Location = new System.Drawing.Point(118, 12);
            this.btnProcessInfo.Name = "btnProcessInfo";
            this.btnProcessInfo.Size = new System.Drawing.Size(100, 23);
            this.btnProcessInfo.TabIndex = 1;
            this.btnProcessInfo.Text = "Process Info";
            this.btnProcessInfo.UseVisualStyleBackColor = true;
            this.btnProcessInfo.Click += new System.EventHandler(this.btnProcessInfo_Click);
            // 
            // btnCloseProcess
            // 
            this.btnCloseProcess.Location = new System.Drawing.Point(224, 12);
            this.btnCloseProcess.Name = "btnCloseProcess";
            this.btnCloseProcess.Size = new System.Drawing.Size(100, 23);
            this.btnCloseProcess.TabIndex = 2;
            this.btnCloseProcess.Text = "Close Process";
            this.btnCloseProcess.UseVisualStyleBackColor = true;
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(330, 12);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(100, 23);
            this.btnKillProcess.TabIndex = 3;
            this.btnKillProcess.Text = "Kill Process";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            // 
            // btnRunApp
            // 
            this.btnRunApp.Location = new System.Drawing.Point(436, 12);
            this.btnRunApp.Name = "btnRunApp";
            this.btnRunApp.Size = new System.Drawing.Size(100, 23);
            this.btnRunApp.TabIndex = 4;
            this.btnRunApp.Text = "Run App";
            this.btnRunApp.UseVisualStyleBackColor = true;
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(542, 12);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(100, 23);
            this.btnStartsWith.TabIndex = 5;
            this.btnStartsWith.Text = "Starts With...";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(12, 70);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(776, 368);
            this.txtOutput.TabIndex = 6;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Type a PID or an app name/path here...";
            this.txtInput.Size = new System.Drawing.Size(776, 23);
            this.txtInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnRunApp);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.btnCloseProcess);
            this.Controls.Add(this.btnProcessInfo);
            this.Controls.Add(this.btnViewProcesses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnViewProcesses;
        private Button btnProcessInfo;
        private Button btnCloseProcess;
        private Button btnKillProcess;
        private Button btnRunApp;
        private Button btnStartsWith;
        private TextBox txtOutput;
        private TextBox txtInput;
    }
}