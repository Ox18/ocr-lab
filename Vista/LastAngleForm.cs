using System;
using System.Windows.Forms;
using Vista.Entity;
using Vista.Controller;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Vista
{
    public partial class LastAngleForm : Form
    {
        public LastAngleEntity lastAngleEntity;

        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        public LastAngleForm()
        {

            this.TopMost = true;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.lastAngleEntity.getChange() == false && lastAngleEntity.getOn())
            {
                this.lastAngleEntity.setChange(true);
                this.lastAngleEntity.setAngle(CaptureController.guessText(pictureCroma));
                this.lastAngleEntity.setChange(false);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void LastAngleForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LastAngleForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LastAngleForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
