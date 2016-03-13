namespace ClockStrategyDesign
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
            this.components = new System.ComponentModel.Container();
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDigital = new System.Windows.Forms.RadioButton();
            this.rdoAnalog = new System.Windows.Forms.RadioButton();
            this.digitalClockLabel = new System.Windows.Forms.Label();
            this.bttn_Start = new System.Windows.Forms.Button();
            this.bttn_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(402, 232);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(320, 320);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAnalog);
            this.groupBox1.Controls.Add(this.rdoDigital);
            this.groupBox1.Location = new System.Drawing.Point(450, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Type";
            // 
            // rdoDigital
            // 
            this.rdoDigital.AutoSize = true;
            this.rdoDigital.Location = new System.Drawing.Point(24, 47);
            this.rdoDigital.Name = "rdoDigital";
            this.rdoDigital.Size = new System.Drawing.Size(78, 24);
            this.rdoDigital.TabIndex = 0;
            this.rdoDigital.TabStop = true;
            this.rdoDigital.Text = "Digital";
            this.rdoDigital.UseVisualStyleBackColor = true;
            this.rdoDigital.CheckedChanged += new System.EventHandler(this.rdoDigital_CheckedChanged);
            // 
            // rdoAnalog
            // 
            this.rdoAnalog.AutoSize = true;
            this.rdoAnalog.Location = new System.Drawing.Point(24, 101);
            this.rdoAnalog.Name = "rdoAnalog";
            this.rdoAnalog.Size = new System.Drawing.Size(84, 24);
            this.rdoAnalog.TabIndex = 1;
            this.rdoAnalog.TabStop = true;
            this.rdoAnalog.Text = "Analog";
            this.rdoAnalog.UseVisualStyleBackColor = true;
            this.rdoAnalog.CheckedChanged += new System.EventHandler(this.rdoAnalog_CheckedChanged);
            // 
            // digitalClockLabel
            // 
            this.digitalClockLabel.AutoSize = true;
            this.digitalClockLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClockLabel.Location = new System.Drawing.Point(89, 322);
            this.digitalClockLabel.Name = "digitalClockLabel";
            this.digitalClockLabel.Size = new System.Drawing.Size(248, 117);
            this.digitalClockLabel.TabIndex = 2;
            this.digitalClockLabel.Text = "00:00";
            // 
            // bttn_Start
            // 
            this.bttn_Start.Location = new System.Drawing.Point(97, 23);
            this.bttn_Start.Name = "bttn_Start";
            this.bttn_Start.Size = new System.Drawing.Size(266, 107);
            this.bttn_Start.TabIndex = 3;
            this.bttn_Start.Text = "Start";
            this.bttn_Start.UseVisualStyleBackColor = true;
            this.bttn_Start.Click += new System.EventHandler(this.bttn_Start_Click);
            // 
            // bttn_Stop
            // 
            this.bttn_Stop.Location = new System.Drawing.Point(97, 136);
            this.bttn_Stop.Name = "bttn_Stop";
            this.bttn_Stop.Size = new System.Drawing.Size(266, 107);
            this.bttn_Stop.TabIndex = 4;
            this.bttn_Stop.Text = "Stop";
            this.bttn_Stop.UseVisualStyleBackColor = true;
            this.bttn_Stop.Click += new System.EventHandler(this.bttn_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 594);
            this.Controls.Add(this.bttn_Stop);
            this.Controls.Add(this.bttn_Start);
            this.Controls.Add(this.digitalClockLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAnalog;
        private System.Windows.Forms.RadioButton rdoDigital;
        private System.Windows.Forms.Label digitalClockLabel;
        private System.Windows.Forms.Button bttn_Start;
        private System.Windows.Forms.Button bttn_Stop;
        private System.Windows.Forms.Timer timer1;
    }
}

