using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace ejer2
{
    public partial class Form1 : Form
    {

        string ip = "192.168.20.100";
        int port = 5001;
        string route = Environment.GetEnvironmentVariable("PROGRAMDATA");
        IPEndPoint ie;
        Socket server;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                ie = new IPEndPoint(IPAddress.Parse(ip), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(ie);
                Debug.WriteLine("Server conection status: " + server.Connected);

                using (NetworkStream ns = new NetworkStream(server))
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {

                    sw.WriteLine("user " + txtUser.Text.Trim());
                    sw.Flush();
                    sw.WriteLine(((Button)sender).Text.ToLower());
                    sw.Flush();
                    txtServer.Text = "";
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        txtServer.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                }
            }
            catch (SocketException ex)
            {
                txtServer.Text = "Error conection: Socket Exception";
                Console.WriteLine("Error connection: \n{0}\nError code: \n{1}\n({2})",
                    ex.Message, (SocketError)ex.ErrorCode, ex.ErrorCode);
            }
            catch (IOException ex)
            {
                txtServer.Text = "Error connection: \nNetwork Stream I/O Exception";
            }
            catch (ArgumentNullException ex)
            {
                txtServer.Text = "Error connection: \nNetwork Stream Argument Null Exception";
            }
            catch (Exception ex)
            {
                txtServer.Text = "Error conection: \n" + ex.ToString();
            }
            
        }

        private void btn_Server(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(route + "/nwEjer2.txt"))
                {
                    ip = sr.ReadLine();
                    Int32.TryParse(sr.ReadLine(), out port);
                }
            }
            catch(FileNotFoundException ex)
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
    }
}