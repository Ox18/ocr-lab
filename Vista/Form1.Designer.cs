namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lastAngle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTitleMiAngulo = new System.Windows.Forms.Label();
            this.checkAutomatizedAngle = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastAngle
            // 
            this.lastAngle.AutoSize = true;
            this.lastAngle.BackColor = System.Drawing.Color.Transparent;
            this.lastAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastAngle.ForeColor = System.Drawing.Color.White;
            this.lastAngle.Location = new System.Drawing.Point(145, 284);
            this.lastAngle.Name = "lastAngle";
            this.lastAngle.Size = new System.Drawing.Size(80, 55);
            this.lastAngle.TabIndex = 0;
            this.lastAngle.Text = "50";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTitleMiAngulo
            // 
            this.txtTitleMiAngulo.AutoSize = true;
            this.txtTitleMiAngulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitleMiAngulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitleMiAngulo.Location = new System.Drawing.Point(152, 255);
            this.txtTitleMiAngulo.Name = "txtTitleMiAngulo";
            this.txtTitleMiAngulo.Size = new System.Drawing.Size(53, 13);
            this.txtTitleMiAngulo.TabIndex = 1;
            this.txtTitleMiAngulo.Text = "Mi angulo";
            // 
            // checkAutomatizedAngle
            // 
            this.checkAutomatizedAngle.AutoSize = true;
            this.checkAutomatizedAngle.BackColor = System.Drawing.Color.Transparent;
            this.checkAutomatizedAngle.Location = new System.Drawing.Point(22, 284);
            this.checkAutomatizedAngle.Name = "checkAutomatizedAngle";
            this.checkAutomatizedAngle.Size = new System.Drawing.Size(114, 17);
            this.checkAutomatizedAngle.TabIndex = 2;
            this.checkAutomatizedAngle.Text = "Angulo automatico";
            this.checkAutomatizedAngle.UseVisualStyleBackColor = false;
            this.checkAutomatizedAngle.CheckedChanged += new System.EventHandler(this.checkAutomatizedAngle_CheckedChanged);
            this.checkAutomatizedAngle.Click += new System.EventHandler(this.checkAutomatizedAngle_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(22, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Barra poder";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(247, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkAutomatizedAngle);
            this.Controls.Add(this.txtTitleMiAngulo);
            this.Controls.Add(this.lastAngle);
            this.Name = "Form1";
            this.Text = "Wind Chart v1.0";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastAngle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtTitleMiAngulo;
        private System.Windows.Forms.CheckBox checkAutomatizedAngle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

