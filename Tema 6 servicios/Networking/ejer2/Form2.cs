
using System.Diagnostics;

namespace ejer2
{
    public partial class Form2 : Form
    {

        string route = Environment.GetEnvironmentVariable("PROGRAMDATA");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(route + "/nwEjer2.txt", false))
                {
                    sw.WriteLine(txtIP.Text);
                    sw.WriteLine(txtPort.Text);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sw = new StreamReader(route + "/nwEjer2.txt"))
                {
                    txtIP.Text = sw.ReadLine();
                    txtPort.Text = sw.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
