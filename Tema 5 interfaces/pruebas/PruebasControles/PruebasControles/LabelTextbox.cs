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
                    OnPosicionChanged(EventArgs.Empty);
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
                    OnSeparacionChanged(EventArgs.Empty);
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

        
        [Category("Appearance")]
        [Description("Indica el caracter usado para enmascarar contraseñas del TextBox del componente")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        [Category("Appearance")]
        [Description("Indica si el TextBox del componente es una contraseña")]
        public bool Psw
        {
            set
            {
                txt.UseSystemPasswordChar = value;
            }
            get
            {
                return txt.UseSystemPasswordChar;
            }
        }

        void recolocar() 
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lblTxt.Location = new Point(0, 0); //Posicion lblTxT
                    txt.Location = new Point(lblTxt.Width + Separacion, 0); //Posicion txt   
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0); //Posicion txt
                    lblTxt.Location = new Point(txt.Width + Separacion, 0); //Posicion lblTxt
                    break;
            }

            this.Width = txt.Width + lblTxt.Width + Separacion; //Ancho componente
            this.Height = Math.Max(txt.Height, lblTxt.Height); //Altura del componente
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            PosicionChanged?.Invoke(this, e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            SeparacionChanged?.Invoke(this, e);
        }

        [Category("Evento personalizado")]
        [Description("Se lanza cuando sucede el evento TextChanged del textbox interno")]
        public event System.EventHandler TxtChanged;

        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            Console.WriteLine(e.KeyValue);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.OnTxtChanged(e);
        }
    }
}
