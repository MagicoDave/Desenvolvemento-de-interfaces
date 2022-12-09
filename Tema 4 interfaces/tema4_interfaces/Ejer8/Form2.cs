using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer8
{
    public partial class Form2 : Form
    {
        public PictureBox PictureBoxSelected
        {
            set { pictureBoxSelected = value; }
            get { return pictureBoxSelected; }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
