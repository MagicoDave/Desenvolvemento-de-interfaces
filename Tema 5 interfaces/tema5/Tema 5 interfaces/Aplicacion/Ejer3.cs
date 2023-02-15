using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Ejer3 : Form
    {
        List<FileInfo> imagenes;
        string[] extensiones = { ".jpg", ".jpeg", ".png", ".gif", ".tif" };
        int imageIndex = 0;
        FormAhorcado formAhorcado;

        public Ejer3()
        {
            InitializeComponent();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            DirectoryInfo directorio = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] files = directorio.GetFiles();
            imagenes = new List<FileInfo>();
            smpControl.SS = 0;
            smpControl.MM = 0;
            imageIndex = 0;

            for (int i = 0; i < files.Length; i++)
            {
                for (int j = 0; j < extensiones.Length; j++)
                {
                    if (files[i].Name.EndsWith(extensiones[j]))
                    {
                        imagenes.Add(files[i]);
                    }
                }
            }

            if (imagenes.Count > 0)
            {
                pbDisplay.Image = Image.FromFile(imagenes[imageIndex].FullName);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            smpControl.SS++;

            if (smpControl.SS % 2 == 0 && imagenes != null)
            {
                imageIndex++;
                if (imageIndex >= imagenes.Count)
                {
                    imageIndex = 0;
                }
                pbDisplay.Image = Image.FromFile(imagenes[imageIndex].FullName);
            }
        }

        private void smpControl_PlayClick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void smpControl_DesbordaTiempo(object sender, EventArgs e)
        {
            smpControl.MM++;
        }

        private void btnAhorcado_Click(object sender, EventArgs e)
        {
            formAhorcado = new FormAhorcado();
            formAhorcado.Show();
        }
    }
}
