using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ejer1_client
{

    //TODO Control de excepciones, configuración de conexion de ip/puerto desde el cliente

    public partial class Form1 : Form
    {
        string ip = "127.0.0.1";
        int port = 31416;
        IPEndPoint ie;
        Socket server;

        public Form1()
        {
            InitializeComponent();
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                ie = new IPEndPoint(IPAddress.Parse(ip), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(ie);
                Debug.WriteLine("Server conection status: " + server.Connected);
            }
            catch (SocketException ex)
            {
                lblServer.Text = "Error conection: Socket Exception";
                Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                    ex.Message, (SocketError)ex.ErrorCode, ex.ErrorCode);
            } catch (Exception ex)
            {
                lblServer.Text = "Error conection: Need to manage this exception";
            }

            try
            {
                using (NetworkStream ns = new NetworkStream(server))
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    if (sender == btnClose)
                    {
                        sw.WriteLine("close " + txtPw.Text);
                    }
                    else
                    {
                        sw.WriteLine(((Button)sender).Text.ToLower());
                    }
                    sw.Flush();
                    lblServer.Text = sr.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                lblServer.Text = "Error connection: Network Stream I/O Exception";
            } catch (ArgumentNullException ex)
            {
                lblServer.Text = "Error connection: Network Stream Argument Null Exception";
            }
            
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtIP)
            {
                ip = ((TextBox)sender).Text;
            }
            else if (sender == txtPort)
            {
                int aux = 0;
                if (Int32.TryParse((((TextBox)sender).Text), out aux))
                {
                    port = aux;
                }
            }
        }
    }
}