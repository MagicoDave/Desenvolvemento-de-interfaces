using System.Collections;

namespace Ejer4
{
    public partial class Form1 : Form
    {

        public delegate double Operacion(double a, double b);
        public string signoOperacion = "+";

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

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}