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
    }
}