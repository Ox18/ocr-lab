using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Main : Form
    {
        private FormMeAngle formMeAngle;
        public Main()
        {
            this.TopMost = true;
            InitializeComponent();
            formMeAngle = new FormMeAngle();
            formMeAngle.Show();
        }
    }
}
