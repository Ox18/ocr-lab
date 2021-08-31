namespace Vista
{
    partial class LastAngleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureCroma = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCroma
            // 
            this.pictureCroma.BackColor = System.Drawing.Color.Lime;
            this.pictureCroma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCroma.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureCroma.Location = new System.Drawing.Point(2, 2);
            this.pictureCroma.Name = "pictureCroma";
            this.pictureCroma.Size = new System.Drawing.Size(46, 30);
            this.pictureCroma.TabIndex = 0;
            this.pictureCroma.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowMerge = false;
            this.contextMenuStrip1.AutoClose = false;
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(36, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(66, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 34);
            this.panel1.TabIndex = 1;
            // 
            // LastAngleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(269, 34);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureCroma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LastAngleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastAngleForm";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LastAngleForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LastAngleForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LastAngleForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCroma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCroma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}