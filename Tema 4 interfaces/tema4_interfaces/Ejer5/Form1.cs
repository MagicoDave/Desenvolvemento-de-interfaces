namespace Ejer5
{
    public partial class Form1 : Form
    {

        string titulo = "     *** Movedor de cosas 1.0 ***";
        int contador = 0;
        bool bonfire = true;

        public Form1()
        {
            InitializeComponent();

            //Imágenes botones mover derecha/izquierda
            btnMoverDerecha.BackgroundImage = Properties.Resources.arrow_right;
            btnMoverDerecha.BackgroundImageLayout = ImageLayout.Zoom;
            btnMoverIzquierda.BackgroundImage = Properties.Resources.arrow_left;
            btnMoverIzquierda.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void btnMoverDerecha_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection aux = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = 0; i < aux.Count; i++)
                {
                    listBox2.Items.Add(aux[i]);
                }

                for (int i = aux.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(aux[i]);
                }              
            }

            contarElementos();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(txtAnadir.Text))
            {
                listBox1.Items.Add(txtAnadir.Text);
            }

            contarElementos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection aux = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = aux.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(aux[i]);
                }
            }

            contarElementos();
        }

        private void btnMoverIzquierda_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection aux = listBox2.SelectedItems;

            if (listBox2.SelectedIndex != -1)
            {
                for (int i = 0; i < aux.Count; i++)
                {
                    listBox1.Items.Add(aux[i]);
                }

                for (int i = aux.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.Remove(aux[i]);
                }
            }

            contarElementos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection aux = listBox1.SelectedIndices;

            lblIndicesSeleccionados.Text = "Indices: ";

            for (int i = 0; i < aux.Count; i++)
            {
                lblIndicesSeleccionados.Text += string.Format("{0,2}/", aux[i]);
            }

        }

        private void contarElementos()
        {
            toolTip1.SetToolTip(this.listBox2, "List Box 2. Elementos: " + listBox2.Items.Count);
            lblCantidadElementos.Text = "Elementos: " + listBox1.Items.Count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador >= titulo.Length)
            {
                contador = 0;
            }
            this.Text = titulo.Substring(titulo.Length - contador, contador);
            contador++;

            if (bonfire)
            {
                this.Icon = Properties.Resources.bonfire_black;
                bonfire = false;
            }
            else
            {
                this.Icon = Properties.Resources.bonfire_color;
                bonfire=true;
            }
        }
    }
}