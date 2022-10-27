namespace Ejer2
{
    public partial class Form1 : Form
    {
        public Color colorOriginalBoton;
        public Form1()
        {
            InitializeComponent();
            colorOriginalBoton = btnColor.BackColor;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int r, g, b;
            if (int.TryParse(txtR.Text, out r)
                && int.TryParse(txtG.Text, out g)
                && int.TryParse(txtB.Text, out b))
            {
                try
                {
                    this.BackColor = Color.FromArgb(r, g, b);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.StackTrace);
                }
            }

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(txtImagen.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "¯\\_(''/)_/¯",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtImagen_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnImagen;
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarColor(object sender, EventArgs e)
        {

        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Tomato;
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorOriginalBoton;
        }
    }
}