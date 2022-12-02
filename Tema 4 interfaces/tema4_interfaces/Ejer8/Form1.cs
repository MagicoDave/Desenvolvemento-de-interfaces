using System.Diagnostics;

namespace Ejer8
{
    public partial class Form1 : Form
    {
        string[] extensiones = { ".jpg", ".jpeg", ".png", ".gif", ".tif" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
             panel1.Controls.Clear();

            folderBrowserDialog1.ShowDialog();
            DirectoryInfo directorio = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] files = directorio.GetFiles();
            List<FileInfo> imagenes = new List<FileInfo>();

            if (directorio.Exists)
            {
                lblDirectorio.Text = "Directorio: " + directorio.Name;
                lblDirectorio.Visible = true;
            } else
            {
                lblDirectorio.Visible = false;
            }

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

            int x = 5;
            int y = 5;

            for (int i = 0; i < imagenes.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(imagenes[i].FullName);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Size = new Size(150,150);
                pic.Location = new Point(x,y);
                panel1.Controls.Add(pic);

                x += 180;
                if (x >= 400)
                {
                    x = 5;
                    y += 180;
                }

            }

            if (imagenes.Count > 0)
            {
                btnAvanzar.Enabled = true;
                btnRetroceso.Enabled = true;


            } else
            {
                btnAvanzar.Enabled = false;
                btnRetroceso.Enabled = false;
            }

        }

        private void actualizarLabels(FileInfo imagen)
        {
            if (imagen.Exists)
            {
                Image aux = Image.FromFile(imagen.FullName);

                lblNombre.Visible = true;
                lblResolucion.Visible = true;
                lblTamano.Visible = true;

                lblNombre.Text = "Nombre: " + imagen.Name;
                lblResolucion.Text = "Resolución: " + aux.Width + "x" + aux.Height;
                lblTamano.Text = string.Format("Tamaño: {0:0.00}MB", imagen.Length / 1024 / 1024);
            }
        }
    }
}