

using System.Diagnostics;

namespace Ejer2
{
    public partial class Form1 : Form
    {
        string homepath = Environment.GetEnvironmentVariable("homepath");
        delegate void Delegado(string direccion, string name, string cad, bool mayusSensitive);

        static readonly private object l = new object();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(homepath + "/extensiones.txt"))
            {
                try
                {
                    StreamReader sr = new StreamReader(homepath + "/extensiones.txt");
                    String aux = sr.ReadToEnd();
                    sr.Close();
                    txtExtensiones.Text = aux;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();

            DirectoryInfo dirInfo;
            FileInfo[] files;

            string directorio = txtDirectorio.Text;

            if (directorio.StartsWith("%") && directorio.EndsWith("%"))
            {
                directorio = Environment.GetEnvironmentVariable(directorio.Substring(1, directorio.Length - 2));
                txtDirectorio.Text = directorio;
            }

            if (Directory.Exists(directorio))
            {
                try
                {
                    Debug.WriteLine("Entro en el try");
                    dirInfo = new DirectoryInfo(directorio);
                    files = dirInfo.GetFiles();
                    Thread t;
                    FileInfo file;

                    for (int i = 0; i < files.Length; i++)
                    {
                        file = files[i];
                        if (txtExtensiones.Text.Equals(""))
                        {
                            
                            if (file.Name.EndsWith(".txt"))
                            {
                                
                                Debug.WriteLine("Entro en instanciación del hilo. File es " + file.Name);
                                t = new Thread(funcionHilo);
                                t.IsBackground = true;
                                t.Start(file);
                            }
                        }
                        else
                        {
                            string[] extensiones = txtExtensiones.Text.Split(',');
                            for (int j = 0; j < extensiones.Length; j++)
                            {
                                if (file.Name.EndsWith(extensiones[j]))
                                {
                                    Debug.WriteLine("Entro en instanciación del hilo. File es " + file.Name);
                                    t = new Thread(funcionHilo);
                                    t.IsBackground = true;
                                    t.Start(file);
                                }
                            }

                        }
                    }

                    StreamWriter sw = new StreamWriter(homepath + "/extensiones.txt", false);
                    sw.Write(txtExtensiones.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contarCadena(string direccion, string nombre, string cad, bool mayusSensitive)
        {
            Debug.WriteLine("Entro en contarCadena");
            int contador = 0;
            string cadena = cad;
            if (!mayusSensitive)
            {
                cadena = cadena.ToLower();
            }

            try
            {

                StreamReader sr = new StreamReader(direccion);
                string texto = sr.ReadToEnd();
                if (!mayusSensitive)
                {
                    texto = texto.ToLower();
                }
                sr.Close();
                if (texto.Contains(cadena))
                {
                    string[] textoArray = texto.Split(',', '.', ' ', '\n', '\r');
                    for (int i = 0; i < textoArray.Length; i++)
                    {
                        if (textoArray[i].Equals(cadena))
                        {
                            contador++;
                        }
                    }
                }

                listBox1.Items.Add(nombre + "---> " + contador + " ocurrencias");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void funcionHilo(object file)
        {
            lock (this)
            {
                Debug.WriteLine("Entro en la funcion del hilo. File es " + ((FileInfo)file).Name);
                Delegado d = contarCadena;
                this.Invoke(d, ((FileInfo)file).FullName, ((FileInfo)file).Name, txtCadena.Text, chkMayus.Checked);
            }
            
        }
    }
}