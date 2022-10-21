#define CARACTER

using System.Media;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        string titulo = "Mouse Tester";
        Color colorOriginal;
        public Form1()
        {
            InitializeComponent();
            this.Text = titulo;
            colorOriginal = button1.BackColor;
        }

        private void SacarCoordenadas(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                this.Text = string.Format("x:{0,4} y:{1,4}", e.X + ((Button)sender).Left, e.Y + ((Button)sender).Top);
            }
            else
            {
                this.Text = string.Format("x:{0,4} y:{1,4}", e.X, e.Y);
            }

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = titulo;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    button1.BackColor = Color.Red;
                    break;
                case MouseButtons.Right:
                    button2.BackColor = Color.Blue;
                    break;
                default:
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Blue;
                    break;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    button1.BackColor = Color.Red;
                    break;
                case MouseButtons.Right:
                    button2.BackColor = Color.Blue;
                    break;
                default:
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    button1.BackColor = colorOriginal;
                    break;
                case MouseButtons.Right:
                    button2.BackColor = colorOriginal;
                    break;
                default:
                    button1.BackColor = colorOriginal;
                    button2.BackColor = colorOriginal;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Text = titulo;
            }
            else
            {
#if CARACTER
                this.Text = e.KeyCode.ToString();
#elif !CARACTER
                this.Text = e.KeyValue.ToString();
#endif 
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", titulo,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}