namespace Ejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}