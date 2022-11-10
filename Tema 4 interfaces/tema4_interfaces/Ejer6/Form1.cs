using System.Windows.Forms;

namespace Ejer6
{
    public partial class Form1 : Form
    {
        int x = 50;
        int y = 100;
        string[] textoBotones = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
        Button btn;
        TextBox txtMovil;
        Color colorDefault;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i < textoBotones.Length; i++)
            {
                btn = new Button();
                btn.Text = textoBotones[i];
                btn.Location = new Point(x, y);
                btn.Size = new Size(50, 20);
                btn.Enabled = true;
                this.btn.Click += new EventHandler(btnClick);
                this.btn.MouseEnter += new EventHandler(btnMouseEnter);
                this.btn.MouseLeave += new EventHandler(btnMouseLeave);
                this.Controls.Add(btn);

                x += 50;
                if (x > 150)
                {
                    x = 50;
                    y += 50;
                }
            }

            txtMovil = new TextBox();
            txtMovil.Location = new Point(x, 50);
            txtMovil.Size = new Size(150, 20);
            txtMovil.Enabled = false;
            this.Controls.Add(txtMovil);

            colorDefault = btn.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Login";
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowDialog();
        }

        private void btnClick(object sender, EventArgs e)
        {
            txtMovil.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Coral;
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {            
           if (((Button)sender).BackColor != Color.Coral)
            {
                ((Button)sender).BackColor = Color.GreenYellow;
            }
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Coral)
            {
                ((Button)sender).BackColor = colorDefault;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMovil.Text = "";
            foreach (Control b in this.Controls)
            {
                if (b.GetType().Equals(typeof(Button)))
                {
                    b.BackColor = colorDefault;
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReset.PerformClick();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vivasPhone es un nuevo modelo que revolucionará el mercado por ser el primer dispositivo móvil que no venda ni una sola unidad.",
                "Acerca de...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information)
            ;


        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter s = new StreamWriter(saveFileDialog1.FileName, true);
            s.Write("\n" + txtMovil.Text);
            s.Close();


        }
    }
}