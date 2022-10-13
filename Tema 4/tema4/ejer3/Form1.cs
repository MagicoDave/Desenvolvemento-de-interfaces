using System.Diagnostics;

namespace ejer3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewProcesses_Click(object sender, EventArgs e)
        {
            Process[] procesos = Process.GetProcesses();
            const string FORMAT = "\r\n{0,7}\t{1,20}\t{2,20}";
            string info = string.Format(FORMAT, "PID", "Name", "Main Window Tittle");
            info += string.Format(FORMAT, "*******", "********************", "********************");
            foreach (Process p in procesos)
            {
                string[] nombres = { p.ProcessName, p.MainWindowTitle };
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombres[i].Length > 20)
                    {
                        nombres[i] = nombres[i].Substring(0, 17) + "...";
                    }
                }
                info += string.Format(FORMAT, p.Id, nombres[0], nombres[1]);
            }
            txtOutput.Text = info;
        }

        private void btnProcessInfo_Click(object sender, EventArgs e)
        {
            int pid;
            bool bandera = true;
            Process p = null;
            ProcessThreadCollection subprocesos = null;
            ProcessModuleCollection modulos = null;


            if (txtInput.Text.Length > 0)
            {
                if (int.TryParse(txtInput.Text, out pid))
                {
                    try
                    {
                        p = Process.GetProcessById(pid);
                        subprocesos = p.Threads;
                        modulos = p.Modules;
                    }
                    catch (Exception)
                    {
                        txtOutput.Text = "The PID introduced was not found/valid";
                        bandera = false;
                    }
                    if (bandera)
                    {
                        string info = string.Format("\r\nShowing info from Process {0} with PID {1}...", p.ProcessName, p.Id);
                        const string FORMATSUBPROCESS = "\r\n{0,7}\t{1,20}\t{2,20}";
                        const string FORMATMODULES = "\r\n{0,20}\t{1,20}";
                        info += "\r\nSUBPROCESS\n\r********************";
                        info += string.Format(FORMATSUBPROCESS, "PID", "Subprocess", "Starting time", "Module name", "File name");
                        for (int i = 0; i < subprocesos.Count; i++)
                        {
                            info += string.Format(FORMATSUBPROCESS, subprocesos[i].Id, subprocesos[i].ToString, subprocesos[i].StartTime);
                        }
                        info += "\r\nMODULES\n\r********************";
                        info += string.Format(FORMATMODULES, "Module name", "File name");
                        for (int j = 0; j < modulos.Count; j++)
                        {
                            info += string.Format(FORMATMODULES, modulos[j].ModuleName, modulos[j].FileName);
                        }

                        txtOutput.Text = info;
                    }

                }

            }
        }
    }
}