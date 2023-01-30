using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5_interfaces
{
    public partial class DibujoAhorcado : Control
    {

        private int errores;

        [Category("Design")]
        [Description("Número de errores (partes del dibujo) del ahorcado")]
        public int Errores
        {
            set { errores = value; }
            get { return errores; }
        }

        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
