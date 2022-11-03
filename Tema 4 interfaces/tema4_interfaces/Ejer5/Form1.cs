namespace Ejer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(txtAnadir.Text))
            {
                listBox1.Items.Add(txtAnadir.Text);
            }
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
        }
    }
}