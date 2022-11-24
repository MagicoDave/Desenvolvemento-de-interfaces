using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer6
{
    public partial class Form2 : Form
    {

        int intentos = 3;
        string pin = "1234";
        bool autentificacion = false;

        public Form2()
        {
            InitializeComponent();
            lblIntentos.Text = "Te queda(n) " + intentos + "intento(s)";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPin.Text == pin)
                {
                    autentificacion = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    txtPin.Text = "";
                    intentos--;
                    lblIntentos.Text = "Te queda(n) " + intentos + "intento(s)";
                    if (intentos == 0)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {         
            if (!autentificacion)
            {
                Application.Exit();
            }
        }
    }
}
