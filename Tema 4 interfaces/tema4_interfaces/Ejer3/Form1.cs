using System;

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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Form2 f2 = new Form2();
                    f2.Text = openFileDialog1.SafeFileName;
                    f2.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    f2.StartPosition = FormStartPosition.CenterScreen;

                    if (chkModal.Checked)
                    {
                        f2.ShowDialog();
                    }
                    else
                    {
                        f2.Show();
                    }
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ha habido un error de memoria al abrir el archivo: " + ex.GetBaseException(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Ha habido un error de memoria al abrir el archivo");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("El método de llamada no es válido para el objeto: " + ex.GetBaseException(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("El método de llamada no es válido para el objeto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha petado loco esto: " + ex.GetBaseException(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.ToString());
                }


            }
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.Font = new Font(CheckBox.DefaultFont, FontStyle.Bold);
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.Font = new Font(CheckBox.DefaultFont, FontStyle.Regular);
                chkModal.ForeColor = Color.Black;
            }
        }
    }
}