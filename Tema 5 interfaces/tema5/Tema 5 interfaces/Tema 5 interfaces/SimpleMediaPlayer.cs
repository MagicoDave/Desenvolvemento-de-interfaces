using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Tema_5_interfaces.Properties;
using System.Runtime.Remoting.Channels;

namespace Tema_5_interfaces
{
    public partial class SimpleMediaPlayer: UserControl
    {

        private int mm = 0;
        private int ss = 0;
        bool isPlaying = false;

        [Category("Value")]
        [Description("Valor del campo 'minutos'")]
        public int MM
        {
            set
            {
                if (mm > 59)
                {
                    mm = 0;
                } else if (mm < 0)
                {
                    throw new ArgumentException("MM no puede ser menor que 0");
                } else
                {
                    mm = value;
                }
                ActualizarLabel();
                this.Refresh();
            }
            get
            {
                return mm;
            }
        }

        [Category("Value")]
        [Description("Valor del campo 'segundos'")]
        public int SS
        {
            set
            {
                if (ss > 59)
                {
                    DesbordaTiempo();
                } else if (ss <0)
                {
                    throw new ArgumentException("SS no puede ser menor que 0");
                } else
                {
                    ss = value;
                }
                ActualizarLabel();
                this.Refresh();
            }
            get 
            {
                return ss;
            }
        }

        public SimpleMediaPlayer()
        {
            InitializeComponent();
        }

        public void ActualizarLabel()
        {
            lblTiempo.Text = $"{MM:00}:{SS:00}";
        }

        public void DesbordaTiempo()
        {
            MM += 1;
            SS = 0;
        }

        [Category("Action")]
        [Description("Se lanza cuando se hace click sobre el botón de play")]
        public event System.EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            PlayClick?.Invoke(this, e);
            
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                btnPlayPause.Image = Resources.pausebutton;
                isPlaying = true;
            }
            else
            {
                btnPlayPause.Image = Resources.playbutton;
                isPlaying = false;
            }
            OnPlayClick(e);
        }
    }
}
