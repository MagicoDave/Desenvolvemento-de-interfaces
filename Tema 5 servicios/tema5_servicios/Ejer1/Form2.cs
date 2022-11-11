using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form2 : Form
    {
        string texto = "";
        public string path = "";

        public Form2()
        {
            InitializeComponent();
        }


        public void setTxtForm2Text(string texto)
        {
            this.texto = texto;
            txtForm2.Text = this.texto;
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!txtForm2.Text.Equals(texto))
            {
                if (MessageBox.Show("¿Quiere guardar las modificaciones?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StreamWriter sw = new StreamWriter(path, false);
                    sw.Write(txtForm2.Text);
                    sw.Close();
                }
            }
        }
    }
}
