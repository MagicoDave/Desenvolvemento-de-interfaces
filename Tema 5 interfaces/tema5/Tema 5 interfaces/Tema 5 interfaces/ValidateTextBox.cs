using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5_interfaces
{

    public enum eTipo
    {
        Numérico,
        Textual
    }

    public partial class ValidateTextBox : UserControl
    {

        private eTipo tipo = eTipo.Textual;
        private bool valida = false;

        [Category("Behavior")]
        [Description("El tipo de datos que el control va a validar")]
        public eTipo Tipo
        {
            get { return tipo; }
            set 
            { 
                tipo = value;
                Actualizar();
            }
        }

        [Category("Appareance")]
        [Description("El texto asociado con el control")]
        public string Texto
        {
            set 
            { 
                txt.Text = value;
                Actualizar();
            }
            get { return txt.Text; }
        }

        [Category("Behavior")]
        [Description("Indica si el control acepta más de una linea o no")]
        public bool Multilinea
        {
            set
            { 
                txt.Multiline = value;
                Actualizar();
            }
            get { return txt.Multiline; }
        }

        public ValidateTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            //Invertir coordenadas
            g.ScaleTransform(1.0F, -1.0F);
            g.TranslateTransform(0.0F, -(float)Height);
            Color color;
            if (valida)
            {
                color = Color.Green;
            } else
            {
                color = Color.Red;
            }
            int h = this.Height;
            int w = this.Width;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen lapiz = new Pen(color, 5);

            g.DrawRectangle(lapiz, 5, 5, w - 10, h - 10);
        }

        private void ValidateTextBox_Resize(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            txt.Width = this.Width - 20;
            if (Multilinea)
            {
                txt.Height = this.Height - 20;
            }
            else
            {
                this.Height = txt.Height + 20;
            }
            this.Refresh();
        }

        [Category("Behavior")]
        [Description("Se lanza cuando se cambia el texto del textbox")]
        public event System.EventHandler TextChange;

        protected virtual void OnTextChange(EventArgs e)
        {
            TextChange?.Invoke(this, e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (tipo == eTipo.Numérico)
            {
                double aux = 0;
                valida = double.TryParse(txt.Text.Trim(), out aux);
            } else if (tipo == eTipo.Textual)
            {
                valida = !txt.Text.Any(char.IsDigit);
            }
            Debug.WriteLine(valida);
            Actualizar();
            OnTextChange(EventArgs.Empty);
        }
    }
}
