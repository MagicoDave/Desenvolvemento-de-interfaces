using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasControles
{

    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }

    public partial class LabelTextbox: UserControl
    {
        public LabelTextbox()
        {
            InitializeComponent();
        }

        //Posición del label respecto al textbox
        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se situa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lblTxt.Text = value;
                recolocar();
            }
            get
            {
                return lblTxt.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        void recolocar() 
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lblTxt.Location = new Point(0, 0); //Posicion lblTxT
                    txt.Location = new Point(lblTxt.Width + Separacion, 0); //Posicion txt
                    txt.Width = this.Width - lblTxt.Width - Separacion; //Ancho txt
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0); //Posicion txt
                    txt.Width = this.Width - lblTxt.Width - Separacion; //Ancho txt
                    lblTxt.Location = new Point(txt.Width + Separacion, 0); //Posicion lblTxt
                    break;
            }

            this.Height = Math.Max(txt.Height, lblTxt.Height); //Altura del componente
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }
    }
}
