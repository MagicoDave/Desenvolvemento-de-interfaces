using System.Collections;

namespace Ejer4
{
    public partial class Form1 : Form
    {

        public delegate double Operacion(double a, double b);
        public string signoOperacion = "+";
        public int minutos = 0;
        public int segundos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbOperacion_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = ((RadioButton)sender).Text;
            signoOperacion = ((RadioButton)sender).Text;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Hashtable operaciones = new Hashtable();
            double a, b;

            Operacion suma = (a, b) => a + b;
            Operacion resta = (a, b) => a - b;
            Operacion multiplicacion = (a, b) => a * b;
            Operacion division = (a, b) => a / b;

            if (double.TryParse(txtNum1.Text, out a) && double.TryParse(txtNum2.Text, out b))
            {
                operaciones.Add("+", suma(a, b));
                operaciones.Add("-", resta(a, b));
                operaciones.Add("*", multiplicacion(a, b));
                operaciones.Add("/", division(a, b));
                lblResultado.Text = string.Format("= {0}", operaciones[signoOperacion]);
            }


        }

        private void textChanged(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(((TextBox)sender).Text, out aux))
            {
                ((TextBox)sender).BackColor = Color.LightGreen;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.IndianRed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos >= 59)
            {
                segundos = 0;
                minutos++;
            }
            segundos++;
            
            this.Text = String.Format("{0,2}:{1,2}", minutos.ToString("D2"), segundos.ToString("D2"));
        }
    }
}