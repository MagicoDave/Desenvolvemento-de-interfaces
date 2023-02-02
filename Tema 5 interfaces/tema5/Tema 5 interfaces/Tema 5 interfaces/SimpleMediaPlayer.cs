using System;
using System.ComponentModel;
using System.Windows.Forms;
using Tema_5_interfaces.Properties;

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
                if (value > 59)
                {
                    mm = 0;
                } else if (value < 0)
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
                if (value > 59)
                {
                    ss = value % 60;
                    OnDesbordaTiempo(EventArgs.Empty);
                } else if (value < 0)
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

        [Category("Action")]
        [Description("Se lanza cuando se hace click sobre el botón de play")]
        public event System.EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            PlayClick?.Invoke(this, e);
        }

        [Category("Behavior")]
        [Description("Se lanza cuando los segundos pasan de 59")]
        public event System.EventHandler DesbordaTiempo;

        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            DesbordaTiempo?.Invoke(this, e);
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
