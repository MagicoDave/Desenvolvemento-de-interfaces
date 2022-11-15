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

            string directorio = txtDireccion.Text;

            if (directorio.StartsWith("%") && directorio.EndsWith("%"))
            {
                directorio = Environment.GetEnvironmentVariable(directorio.Substring(1, directorio.Length - 2));
                txtDireccion.Text = directorio;
            }

            if (Directory.Exists(directorio))
            {
                try
                {
                    dirActual = new DirectoryInfo(directorio);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("La dirección está probablemente mal escrita");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    DirectoryInfo di = new DirectoryInfo(txtDireccion.Text);
                    String parent = di.Parent.FullName;
                    txtDireccion.Text = parent;
                    btnCambiarDirectorio.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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