using System.Diagnostics;
using System.Linq.Expressions;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarDirectorio_Click(object sender, EventArgs e)
        {
            listBoxDirectorios.Items.Clear();
            listBoxArchivos.Items.Clear();

            DirectoryInfo dirActual;
            DirectoryInfo[] subdirs;
            FileInfo[] files;

            if (Directory.Exists(txtDireccion.Text))
            {
                dirActual = new DirectoryInfo(txtDireccion.Text);
                subdirs = dirActual.GetDirectories();
                files = dirActual.GetFiles();

                if (dirActual.Parent != null)
                {
                    listBoxDirectorios.Items.Add("..");
                }

                for (int i = 0; i < subdirs.Length; i++)
                {
                    listBoxDirectorios.Items.Add(subdirs[i].Name);
                }

                for (int i = 0; i < files.Length; i++)
                {
                    listBoxArchivos.Items.Add(files[i].Name);
                }
            }
        }

        private void listBoxArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo file;

            comprobarBarra();

            if (listBoxArchivos.SelectedIndex != -1)
            {
                try
                {
                    file = new FileInfo(txtDireccion.Text + listBoxArchivos.SelectedItem.ToString());
                    lblNombreArchivo.Text = "Nombre: " + file.Name;
                    lblTamanoArchivo.Text = string.Format("Tamaño: {0:0.0###}KB", (file.Length / 1024));
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("La dirección está probablemente mal escrita");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                lblNombreArchivo.Text = "Nombre: ";
                lblTamanoArchivo.Text = "Tamaño: ";
            }
        }

        private void listBoxDirectorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobarBarra();

            if ((string) listBoxDirectorios.SelectedItem != "..")
            {
                txtDireccion.Text += listBoxDirectorios.SelectedItem.ToString();
                btnCambiarDirectorio.PerformClick();
            } else
            {
                DirectoryInfo di = new DirectoryInfo(txtDireccion.Text);
                String parent = di.Parent.FullName;
                txtDireccion.Text = parent;
                btnCambiarDirectorio.PerformClick();
            }
        }

        private void comprobarBarra()
        {
            if (!txtDireccion.Text.Substring(txtDireccion.Text.Length - 1).Equals("/"))
            {
                txtDireccion.Text += "/";
            }
        }

        private void listBoxArchivos_DoubleClick(object sender, EventArgs e)
        {
            

            if (listBoxArchivos.SelectedIndex != -1)
            {
                string nombre = listBoxArchivos.SelectedItem.ToString();
                if (nombre.Length > 4 && nombre.Substring(nombre.Length - 4).Equals(".txt"))
                {
                    StreamReader sr = new StreamReader(txtDireccion.Text + nombre);
                    string texto = sr.ReadToEnd();
                    sr.Close();

                    Form2 f2 = new Form2();
                    f2.Text = nombre;
                    f2.path = txtDireccion.Text + nombre;
                    f2.StartPosition = FormStartPosition.CenterScreen;
                    f2.setTxtForm2Text(texto);
                    f2.ShowDialog();
                }
            }
        }
    }
}