
using System.Diagnostics;

namespace ejer2
{
    public partial class Form2 : Form
    {

        string route = Environment.GetEnvironmentVariable("PROGRAMDATA");
        string ip;
        int port;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(route + "/nwEjer2.txt"))
                {
                    ip = sr.ReadLine();
                    Int32.TryParse(sr.ReadLine(), out port);
                    txtIP.Text = ip;
                    txtPort.Text = port.ToString();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "No se ha encontrado el archivo", MessageBoxButtons.OK);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error de lectura", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int aux = 0;
                if (validarIP(txtIP.Text) 
                    && Int32.TryParse(txtPort.Text, out aux) 
                    && aux >= 1
                    && aux <= 65535)
                {
                    using (StreamWriter sw = new StreamWriter(route + "/nwEjer2.txt", false))
                    {
                        sw.WriteLine(txtIP.Text);
                        sw.WriteLine(txtPort.Text);
                    }
                    this.Close();
                } else
                {
                    MessageBox.Show("Los valores de la ip y/o el puerto no son validos", "Valores no válidos", MessageBoxButtons.OK);
                    txtIP.Text = ip;
                    txtPort.Text = port.ToString();
                }
                
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "No se ha encontrado el archivo", MessageBoxButtons.OK);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error de escritura", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public bool validarIP(string ip)
        {
            if (ip.Trim() == "")
            {
                return false;
            }

            string[] partes = ip.Split('.');
            if (partes.Length != 4)
            {
                return false;
            }

            byte aux;

            return partes.All(parte => byte.TryParse(parte, out aux));
        }
    }
}
