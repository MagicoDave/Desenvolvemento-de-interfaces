namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("¿Desea poner \"" + textBox1.Text + "\" como título?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            
            if (a == DialogResult.Yes)
            {
                this.Text=textBox1.Text;
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}