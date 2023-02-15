using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FormAhorcado : Form
    {

        string solucion = "supercorbata";


        public FormAhorcado()
        {
            InitializeComponent();
        }

        private void txtAhorcado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtAhorcado.Text == solucion)
            {
                MessageBox.Show("HAS GANADO", "SUPERCORBATA", MessageBoxButtons.OK);
            } else
            {
                ahorcado.Errores++;
            }
        }

        private void ahorcado_Ahorcado(object sender, EventArgs e)
        {
            MessageBox.Show("LA LIASTE", "SUPERCORBATA", MessageBoxButtons.OK);
        }
    }
}
