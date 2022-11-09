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

        public Form2()
        {
            InitializeComponent();
            lblIntentos.Text = "Te queda(n) " + intentos + "intento(s)";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPin.Text.Equals(pin))
                {
                    this.Close();
                }
                else
                {
                    txtPin.Text = "";
                    intentos--;
                    lblIntentos.Text = "Te queda(n) " + intentos + "intento(s)";
                    if (intentos == 0)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
