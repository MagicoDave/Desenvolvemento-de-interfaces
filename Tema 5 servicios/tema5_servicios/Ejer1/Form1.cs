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
            lblError.Visible = false;
            listBoxDirectorios.Items.Clear();
            listBoxArchivos.Items.Clear();
            lblNombreArchivo.Text = "Nombre: ";
            lblTamanoArchivo.Text = "Tamaño: ";

            DirectoryInfo dirActual;
            DirectoryInfo[] subdirs;
            FileInfo[] files;
            string directorio = txtDireccion.Text;

            if (directorio.StartsWith("%") && directorio.EndsWith("%") && directorio.Length >= 3)
            {
                try
                {
                    directorio = Environment.GetEnvironmentVariable(directorio.Substring(1, directorio.Length - 2));
                    if (directorio == null)
                    {
                        lblError.Visible = true;
                        lblError.Text = "No se ha encontrado la variable de entorno";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDireccion.Text = directorio;
            }

            if (directorio == "..")
            {
                try
                {
                    DirectoryInfo aux = Directory.GetParent(directorio);
                    if (aux == null)
                    {
                        lblError.Visible = true;
                        lblError.Text = "No existe directorio padre";
                    }
                    else
                    {
                        Directory.SetCurrentDirectory("../");
                        directorio = Directory.GetCurrentDirectory();
                        lblDireccion.Text = Directory.GetCurrentDirectory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            
            if (Directory.Exists(directorio))
            {
                bool error = false;
                try
                {
                    Directory.SetCurrentDirectory(directorio);
                    txtDireccion.Text = Directory.GetCurrentDirectory();
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

                    txtDireccion.Text = Directory.GetCurrentDirectory();
                    txtDireccion.SelectionStart = txtDireccion.Text.Length;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            } else
            {
                lblError.Visible = true;
                lblError.Text = "El directorio no existe";
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

            if ((string) listBoxDirectorios.SelectedItem != ".." && listBoxDirectorios.SelectedIndex != -1)
            {
                    btnCambiarDirectorio.PerformClick();          
            } else
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
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