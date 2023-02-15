using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5_interfaces
{
    public partial class DibujoAhorcado : Control
    {

        private int errores = 0;

        [Category("Design")]
        [Description("Número de errores (partes del dibujo) del ahorcado")]
        public int Errores
        {
            set
            { 
                errores = value;
                OnCambiaError(EventArgs.Empty);
                this.Refresh();
                if (errores >= 10)
                {
                    OnAhorcado(EventArgs.Empty);
                }
            }
            get { return errores; }
        }

        public DibujoAhorcado()
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
            //Grosor lineas dibujo
            int grosor = 10;
            int h = this.Height;
            int w = this.Width;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen lapiz = new Pen(Color.Red, grosor);

            switch (errores)
            {
                case int n when n > 10:
                case 10: //Pierna derecha
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - grosor - h / 2), (w - (w / 5) + (grosor / 2)), (grosor + h / 4));
                    goto case 9;
                case 9: //Pierna izquierda
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - grosor - h / 2), (w - (w / 3) + (grosor / 2)), (grosor + h/4));
                    goto case 8;
                case 8: //Brazo derecho
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - grosor - h / 4), (w - (w / 5) + (grosor / 2)), (h - grosor - h / 2));
                    goto case 7;
                case 7: //Brazo izquierdo
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - grosor - h / 4), (w - (w/3) + (grosor / 2)), (h - grosor - h / 2));
                    goto case 6;
                case 6: //Tronco
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - grosor - h / 5), (w - (w / 4) + (grosor / 2)), (h - grosor - h / 2));
                    goto case 5;
                case 5: //Cabeza
                    g.DrawEllipse(lapiz, (w - (w / 3) + (grosor / 2)), (h - grosor - h / 5), w/8, h/8);
                    goto case 4;
                case 4: //Cuerda
                    g.DrawLine(lapiz, (w - (w / 4) + (grosor / 2)), (h - (grosor/2)), (w - (w / 4) + (grosor / 2)), (h - grosor - h/10));
                    goto case 3;
                case 3: //Palo horizontal
                    g.DrawLine(lapiz, (w / 4 + (grosor / 2)), (h - grosor), (w - (w/4) + (grosor / 2)), (h - grosor));
                    goto case 2;
                case 2: //Palo vertical
                    g.DrawLine(lapiz, w/4 + (grosor/2), grosor, w/4 + (grosor / 2), h - grosor);
                    goto case 1;
                case 1: //Base
                    g.DrawLine(lapiz, grosor, grosor, w/2 + grosor, grosor);
                    break;
                default:
                    break;
            }

            lapiz.Dispose();
            g.Dispose();
        }

        [Category("Behavior")]
        [Description("Se lanza cuando cambia el número de errores")]
        public event System.EventHandler CambiaError;

        protected virtual void OnCambiaError(EventArgs e)
        {
            CambiaError?.Invoke(this, e);
        }

        [Category("Behavior")]
        [Description("Se lanza cuando se completa el dibujo")]
        public event System.EventHandler Ahorcado;

        protected virtual void OnAhorcado(EventArgs e)
        {
            Ahorcado?.Invoke(this, e);
        }
    }
}
