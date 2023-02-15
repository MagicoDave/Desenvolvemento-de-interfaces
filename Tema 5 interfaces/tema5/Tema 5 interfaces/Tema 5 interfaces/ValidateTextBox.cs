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
    }
}
