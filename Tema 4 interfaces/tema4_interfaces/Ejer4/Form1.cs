using System.Collections;

namespace Ejer4
{
    public partial class Form1 : Form
    {

        public delegate double Operacion(double a, double b);
        public string signoOperacion = "+";
        public int minutos = 0;
        public int segundos = 55;
        double a, b;
        Hashtable operaciones = new Hashtable();

        public Form1()
        {
            InitializeComponent();

            operaciones.Add("+", (Operacion)((a, b) => a + b));
            operaciones.Add("-", (Operacion)((a, b) => a - b));
            operaciones.Add("*", (Operacion)((a, b) => a * b));
            operaciones.Add("/", (Operacion)((a, b) => a / b));
            
        }

        private void rbOperacion_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = ((RadioButton)sender).Text;
            signoOperacion = ((RadioButton)sender).Text;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out a) && double.TryParse(txtNum2.Text, out b))
            {
                lblResultado.Text = string.Format("= {0:0.####}", ((Operacion)operaciones[signoOperacion])(a,b));
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(((TextBox)sender).Text, out aux))
            {
                ((TextBox)sender).BackColor = Color.LightGreen;
            } else if (((TextBox) sender).Text == "")
            {
                ((TextBox)sender).BackColor = Color.White;
            } else
            {
                ((TextBox)sender).BackColor = Color.IndianRed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos > 59)
            {
                segundos = 0;
                minutos++;
            }
            
            
            this.Text = String.Format("{0,2}:{1,2}", minutos.ToString("D2"), segundos.ToString("D2"));
        }
    }
}