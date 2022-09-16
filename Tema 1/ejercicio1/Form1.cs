namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a;
            int b;

            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                label2.Text = "= " + (a + b);
            }
            catch (FormatException)
            {
                Console.WriteLine("No se pudo convertir a int");
            }
            
        }
    }
}