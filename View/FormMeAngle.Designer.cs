namespace View
{
    partial class FormMeAngle
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
            this.pictureMeAngle = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMeAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureMeAngle
            // 
            this.pictureMeAngle.BackColor = System.Drawing.Color.Lime;
            this.pictureMeAngle.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureMeAngle.Location = new System.Drawing.Point(2, 2);
            this.pictureMeAngle.Name = "pictureMeAngle";
            this.pictureMeAngle.Size = new System.Drawing.Size(47, 37);
            this.pictureMeAngle.TabIndex = 0;
            this.pictureMeAngle.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMeAngle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(51, 41);
            this.Controls.Add(this.pictureMeAngle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMeAngle";
            this.Text = "FormMeAngle";
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.pictureMeAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMeAngle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}