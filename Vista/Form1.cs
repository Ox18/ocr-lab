using System;
using System.Windows.Forms;
using Vista.Entity;

namespace Vista
{
    public partial class Form1 : Form
    {

        private LastAngleEntity lastAngleEntity = new LastAngleEntity();
        private LastAngleForm lastAngleForm;
        private BarForm barForm;

        public Form1()
        {
            this.TopMost = true;
            InitializeComponent();

            this.lastAngleForm = new LastAngleForm();
            lastAngleForm.lastAngleEntity = this.lastAngleEntity;
            lastAngleForm.Show();
            lastAngleForm.Visible = false;

            this.barForm = new BarForm();
            barForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.lastAngleEntity.getOn())
            {
                lastAngle.Text = this.lastAngleEntity.getAngle();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void checkAutomatizedAngle_Click(object sender, EventArgs e)
        {
            if (checkAutomatizedAngle.Checked)
            {
                this.lastAngleEntity.setOn(true);
                this.lastAngleForm.Visible = true;
            }
            else
            {
                this.lastAngleForm.Visible = false;
                this.lastAngleEntity.setOn(false);
            }
        }

        private void checkAutomatizedAngle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
