using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PruebasControles
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    [DefaultProperty("Marca")]
    public partial class EtiquetaAviso : Control
    {

        private eMarca marca = eMarca.Nada;
        private Image imagenMarca;
        private Color colorPrincipal = Color.White;
        private Color colorSecundario = Color.LightBlue;
        private bool gradiente = true;
        private int offsetX = 0;

        [Category("Appareance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        [Category("Appareance")]
        [Description("Indica la imagen que se mostrará si se escoge la marca 'Imagen'")]
        public Image ImagenMarca
        {
            set 
            {
                imagenMarca = value;
                this.Refresh();
            }
            get 
            { 
                return this.imagenMarca;
            }
        }

        [Category("Appareance")]
        [Description("Indica el primer color del gradiente")]
        public Color ColorPrincipal
        {
            set
            {
                colorPrincipal = value;
                this.Refresh();
            }
            get
            {
                return colorPrincipal;
            }
        }

        [Category("Appareance")]
        [Description("Indica el segundo color del gradiente")]
        public Color ColorSecundario
        {
            set
            {
                colorSecundario = value;
                this.Refresh();
            }
            get
            {
                return colorSecundario;
            }
        }

        [Category("Appareance")]
        [Description("Indica si hay fondo con gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            int grosor = 0; //Grosor lineas dibujo
            offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento a la izquierda del texto
            int h = this.Font.Height; //Altura de la fuente

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    break;
                case eMarca.Imagen:
                    if (ImagenMarca != null)
                    {
                        offsetX = h;
                    }
                    break;
            }

            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

            if (Gradiente)
            {
                LinearGradientBrush lgb = new LinearGradientBrush(
                    new Point(0, tam.Height),
                    new Point(tam.Width*2, tam.Height), 
                    ColorPrincipal, 
                    ColorSecundario);
                g.FillRectangle(lgb, new Rectangle(0, 0, this.Size.Width, this.Size.Height));
                lgb.Dispose();
            }

            switch (Marca)
            {
                case eMarca.Circulo:
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
                    break;
                case eMarca.Cruz:
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (ImagenMarca != null)
                    {
                        g.DrawImage(ImagenMarca, new Rectangle(0, 0, h, h));
                    }
                    break;
            }

            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            b.Dispose();
        }

        [Category("Action")]
        [Description("Se lanza cuando se hace click sobre la marca (si existe)")]
        public event System.EventHandler ClickEnMarca;

        protected virtual void OnClickEnMarca(EventArgs e)
        {
            ClickEnMarca?.Invoke(this, e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (Marca != eMarca.Nada 
                && (e.X <  offsetX)
            )
            {
                OnClickEnMarca(EventArgs.Empty);
            }
        }


    }
}
