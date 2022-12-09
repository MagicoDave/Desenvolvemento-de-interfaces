using System.Diagnostics;

namespace Ejer8
{
    public partial class Form1 : Form
    {
        string[] extensiones = { ".jpg", ".jpeg", ".png", ".gif", ".tif" };
        Form2 f2;
        List<FileInfo> imagenes;
        int selectedPic = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (f2 != null)
            {
                f2.Close();
            }
            btnAvanzar.Enabled = false;
            btnRetroceso.Enabled = false;

            folderBrowserDialog1.ShowDialog();
            DirectoryInfo directorio = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] files = directorio.GetFiles();
            imagenes = new List<FileInfo>();

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
                pic.Click += new System.EventHandler(clickPic);
                pic.Tag = i;
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
                f2 = new Form2();
                actualizarF2(imagenes[0]);
                actualizarLabels(imagenes[0]);
                selectedPic = 0;
                f2.Show();
            } else
            {
                Label lbl = new Label();
                lbl.Text = "No se han encontrado imágenes en este directorio";
                lbl.Location = new Point(5, 5);
                lbl.Size = lbl.GetPreferredSize(new Size());
                panel1.Controls.Add(lbl);
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

                if (imagen.Name.Length > 30)
                {
                    lblNombre.Text = "Nombre: " + imagen.Name.Substring(0,27) + "...";
                } else
                {
                    lblNombre.Text = "Nombre: " + imagen.Name;
                }
                lblResolucion.Text = "Resolución: " + aux.Width + "x" + aux.Height;
                if (imagen.Length < 1024*1024)
                {
                    lblTamano.Text = string.Format("Tamaño: {0:0.00}KB", imagen.Length / 1024);
                } else
                {
                    lblTamano.Text = string.Format("Tamaño: {0:0.00}MB", imagen.Length / 1024 / 1024);
                }
                
            }
        }

        private void actualizarF2(FileInfo imagen)
        {
            if (imagen.Exists)
            {
                f2.Text = imagen.Name;
                f2.PictureBoxSelected.Image = Image.FromFile(imagen.FullName);
                f2.Size = new Size(f2.PictureBoxSelected.Width, f2.PictureBoxSelected.Height);
            }
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {    
            if (imagenes.Count > 0 && selectedPic > 0)
            {
                if (f2.IsDisposed)
                {
                    f2 = new Form2();
                    f2.Show();
                }
                selectedPic--;
                actualizarF2(imagenes[selectedPic]);
                actualizarLabels(imagenes[selectedPic]);
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0 && selectedPic < imagenes.Count - 1)
            {
                if (f2.IsDisposed)
                {
                    f2 = new Form2();
                    f2.Show();
                }
                selectedPic++;
                actualizarF2(imagenes[selectedPic]);
                actualizarLabels(imagenes[selectedPic]);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && btnAvanzar.Enabled == true)
            {
                btnAvanzar.PerformClick();
            }
            if (e.KeyCode == Keys.A && btnRetroceso.Enabled == true)
            {
                btnRetroceso.PerformClick();
            }
        }

        private void clickPic(object sender, EventArgs e)
        {
            selectedPic = (Int32)((PictureBox)sender).Tag;
            actualizarF2(imagenes[selectedPic]);
            actualizarLabels(imagenes[selectedPic]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                    "¿Seguro que quieres salir?",
                    "Visor de imágenes",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question)
             == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}