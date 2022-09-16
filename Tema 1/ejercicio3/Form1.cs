#define DEPURACION

using System.ComponentModel;

namespace ejercicio3
{
    public partial class Form1 : Form
    {

        public int credito = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (credito >= 2)
            {
                credito -= 2;
                Random generador = new Random();

                int a = generador.Next(1, 8);
                int b = generador.Next(1, 8);
                int c = generador.Next(1, 8);

                textBox1.Text = a.ToString();
                textBox2.Text = b.ToString();
                textBox3.Text = c.ToString();

                if (a == b && a == c)
                {
                    label1.Text = "¡Premio gordo! +20€";
                    credito += 20;
                }
                else if (a == b || a == c || b == c)
                {
#if DEPURACION
                    label1.Text = "Cosas de depuración -5€";
                    credito -= 5;
                    
#else
                    label1.Text = "¡Premio mediano! +5€";
                    credito += 5;
#endif
                }
                else
                {
                    label1.Text = "Mala suerte, vuelve a intentarlo";
                }
            } else
            {
                label1.Text = "No tienes suficiente crédito";
            }

            if (credito < 0)
            {
                credito = 0;
            }

            label2.Text = credito + "€";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            credito += 10;
            label2.Text = credito.ToString();
        }
    }
}