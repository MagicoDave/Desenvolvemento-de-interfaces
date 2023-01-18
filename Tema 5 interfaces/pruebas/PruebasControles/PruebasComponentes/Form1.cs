using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelTextbox1.Separacion = 2;
            labelTextbox1.TextLbl = "HOLA";
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            this.Text = "Cruz roja";
        }

        private void etiquetaAviso2_ClickEnMarca(object sender, EventArgs e)
        {
            this.Text = "Circulo verde";
        }

        private void etiquetaAviso3_ClickEnMarca(object sender, EventArgs e)
        {
            this.Text = "Minidave";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelTextbox1.Posicion == PruebasControles.ePosicion.IZQUIERDA)
            {
                labelTextbox1.Posicion = PruebasControles.ePosicion.DERECHA;
                this.Text = PruebasControles.ePosicion.DERECHA.ToString();
            } else
            {
                labelTextbox1.Posicion = PruebasControles.ePosicion.IZQUIERDA;
                this.Text = PruebasControles.ePosicion.IZQUIERDA.ToString();
            }
        }

        private void txtSeparacion_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            if (Int32.TryParse(txtSeparacion.Text, out aux))
            {
                labelTextbox1.Separacion = aux;
            }
        }

        private void labelTextbox1_SeparacionChanged(object sender, EventArgs e)
        {
            labelTextbox1.TextLbl = "Separacion = " + labelTextbox1.Separacion;
        }
    }
}
