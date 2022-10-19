using System.Diagnostics;
using System.Security.Cryptography;

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
            verProcesos();
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
                            info += string.Format(FORMATSUBPROCESS, subprocesos[i].Id, recortarCadena(subprocesos[i].ToString(), 20), subprocesos[i].StartTime);
                        }
                        info += "\r\nMODULES\n\r********************";
                        info += string.Format(FORMATMODULES, "Module name", "File name");
                        for (int j = 0; j < modulos.Count; j++)
                        {
                            info += string.Format(FORMATMODULES, recortarCadena(modulos[j].ModuleName, 20), recortarCadena(modulos[j].FileName, 20));
                        }

                        txtOutput.Text = info;
                    }

                }

            }
        }

        private void btnCloseProcess_Click(object sender, EventArgs e)
        {

            int pid;
            bool bandera = true;
            Process p = null;

            if (txtInput.Text.Length > 0)
            {
                if (int.TryParse(txtInput.Text, out pid))
                {
                    try
                    {
                        p = Process.GetProcessById(pid);
                    }
                    catch (Exception)
                    {
                        txtOutput.Text = "The PID introduced was not found/valid";
                        bandera = false;
                    }

                    if (bandera)
                    {
                        p.CloseMainWindow();
                    }
                }
            }
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            int pid;
            bool bandera = true;
            Process p = null;

            if (txtInput.Text.Length > 0)
            {
                if (int.TryParse(txtInput.Text, out pid))
                {
                    try
                    {
                        p = Process.GetProcessById(pid);
                    }
                    catch (Exception)
                    {
                        txtOutput.Text = "The PID introduced was not found/valid";
                        bandera = false;
                    }

                    if (bandera)
                    {
                        p.Kill();
                    }
                }
            }
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                try
                {  
                    Process p = Process.Start(txtInput.Text);
                }
                catch (Exception)
                {
                    txtOutput.Text = "The PID introduced was not found/valid";
                }
            }
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                verProcesos(txtInput.Text);
            }
        }

        private string recortarCadena(string cadena, int n)
        {
            if (cadena.Length > n)
            {
                return cadena.Substring(0, n - 3) + "...";
            }

            return cadena;
        }

        private void verProcesos (string empiezaPor = "")
        {
            Process[] procesos = Process.GetProcesses();
            const string FORMAT = "\r\n{0,7}\t{1,20}\t{2,20}";
            string info = string.Format(FORMAT, "PID", "Name", "Main Window Tittle");
            info += string.Format(FORMAT, "*******", "********************", "********************");
            foreach (Process p in procesos)
            {
                if (p.ProcessName.StartsWith(empiezaPor))
                {
                    string[] nombres = { p.ProcessName, p.MainWindowTitle };
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nombres[i] = recortarCadena(nombres[i], 20);
                    }
                    info += string.Format(FORMAT, p.Id, nombres[0], nombres[1]);
                }
            }
            txtOutput.Text = info;
        }
    }
}