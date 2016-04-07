namespace FireAlarm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Inferno = new System.Windows.Forms.RadioButton();
            this.rdo_Serious = new System.Windows.Forms.RadioButton();
            this.rdo_Minor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Inferno);
            this.groupBox1.Controls.Add(this.rdo_Serious);
            this.groupBox1.Controls.Add(this.rdo_Minor);
            this.groupBox1.Location = new System.Drawing.Point(44, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarms";
            // 
            // rdo_Inferno
            // 
            this.rdo_Inferno.AutoSize = true;
            this.rdo_Inferno.Location = new System.Drawing.Point(7, 182);
            this.rdo_Inferno.Name = "rdo_Inferno";
            this.rdo_Inferno.Size = new System.Drawing.Size(85, 24);
            this.rdo_Inferno.TabIndex = 2;
            this.rdo_Inferno.TabStop = true;
            this.rdo_Inferno.Text = "Inferno";
            this.rdo_Inferno.UseVisualStyleBackColor = true;
            // 
            // rdo_Serious
            // 
            this.rdo_Serious.AutoSize = true;
            this.rdo_Serious.Location = new System.Drawing.Point(7, 114);
            this.rdo_Serious.Name = "rdo_Serious";
            this.rdo_Serious.Size = new System.Drawing.Size(88, 24);
            this.rdo_Serious.TabIndex = 1;
            this.rdo_Serious.TabStop = true;
            this.rdo_Serious.Text = "Serious";
            this.rdo_Serious.UseVisualStyleBackColor = true;
            // 
            // rdo_Minor
            // 
            this.rdo_Minor.AutoSize = true;
            this.rdo_Minor.Location = new System.Drawing.Point(7, 52);
            this.rdo_Minor.Name = "rdo_Minor";
            this.rdo_Minor.Size = new System.Drawing.Size(73, 24);
            this.rdo_Minor.TabIndex = 0;
            this.rdo_Minor.TabStop = true;
            this.rdo_Minor.Text = "Minor";
            this.rdo_Minor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Inferno;
        private System.Windows.Forms.RadioButton rdo_Serious;
        private System.Windows.Forms.RadioButton rdo_Minor;
    }
}

