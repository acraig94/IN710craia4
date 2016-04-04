namespace Progress_Indicator
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_PBar = new System.Windows.Forms.RadioButton();
            this.rdo_TrackBar = new System.Windows.Forms.RadioButton();
            this.rdo_spin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 235);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(497, 50);
            this.progressBar1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(53, 363);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(497, 69);
            this.trackBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_spin);
            this.groupBox1.Controls.Add(this.rdo_TrackBar);
            this.groupBox1.Controls.Add(this.rdo_PBar);
            this.groupBox1.Location = new System.Drawing.Point(720, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdo_PBar
            // 
            this.rdo_PBar.AutoSize = true;
            this.rdo_PBar.Location = new System.Drawing.Point(7, 73);
            this.rdo_PBar.Name = "rdo_PBar";
            this.rdo_PBar.Size = new System.Drawing.Size(126, 24);
            this.rdo_PBar.TabIndex = 0;
            this.rdo_PBar.TabStop = true;
            this.rdo_PBar.Text = "Progress Bar";
            this.rdo_PBar.UseVisualStyleBackColor = true;
            // 
            // rdo_TrackBar
            // 
            this.rdo_TrackBar.AutoSize = true;
            this.rdo_TrackBar.Location = new System.Drawing.Point(7, 124);
            this.rdo_TrackBar.Name = "rdo_TrackBar";
            this.rdo_TrackBar.Size = new System.Drawing.Size(102, 24);
            this.rdo_TrackBar.TabIndex = 1;
            this.rdo_TrackBar.TabStop = true;
            this.rdo_TrackBar.Text = "Track Bar";
            this.rdo_TrackBar.UseVisualStyleBackColor = true;
            // 
            // rdo_spin
            // 
            this.rdo_spin.AutoSize = true;
            this.rdo_spin.Location = new System.Drawing.Point(7, 26);
            this.rdo_spin.Name = "rdo_spin";
            this.rdo_spin.Size = new System.Drawing.Size(93, 24);
            this.rdo_spin.TabIndex = 2;
            this.rdo_spin.TabStop = true;
            this.rdo_spin.Text = "SpinBox";
            this.rdo_spin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 111);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 506);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_spin;
        private System.Windows.Forms.RadioButton rdo_TrackBar;
        private System.Windows.Forms.RadioButton rdo_PBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

