namespace ORM_Linq
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
            this.btn_Q1 = new System.Windows.Forms.Button();
            this.btn_Q2 = new System.Windows.Forms.Button();
            this.btn_Q3 = new System.Windows.Forms.Button();
            this.btn_Q4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Q1
            // 
            this.btn_Q1.Location = new System.Drawing.Point(61, 47);
            this.btn_Q1.Name = "btn_Q1";
            this.btn_Q1.Size = new System.Drawing.Size(178, 44);
            this.btn_Q1.TabIndex = 0;
            this.btn_Q1.Text = "Average intensity";
            this.btn_Q1.UseVisualStyleBackColor = true;
            this.btn_Q1.Click += new System.EventHandler(this.btn_Q1_Click);
            // 
            // btn_Q2
            // 
            this.btn_Q2.Location = new System.Drawing.Point(61, 114);
            this.btn_Q2.Name = "btn_Q2";
            this.btn_Q2.Size = new System.Drawing.Size(178, 44);
            this.btn_Q2.TabIndex = 1;
            this.btn_Q2.Text = "Largest 3 fires";
            this.btn_Q2.UseVisualStyleBackColor = true;
            this.btn_Q2.Click += new System.EventHandler(this.btn_Q2_Click);
            // 
            // btn_Q3
            // 
            this.btn_Q3.Location = new System.Drawing.Point(61, 179);
            this.btn_Q3.Name = "btn_Q3";
            this.btn_Q3.Size = new System.Drawing.Size(178, 44);
            this.btn_Q3.TabIndex = 2;
            this.btn_Q3.Text = "Pictures location";
            this.btn_Q3.UseVisualStyleBackColor = true;
            this.btn_Q3.Click += new System.EventHandler(this.btn_Q3_Click);
            // 
            // btn_Q4
            // 
            this.btn_Q4.Location = new System.Drawing.Point(61, 248);
            this.btn_Q4.Name = "btn_Q4";
            this.btn_Q4.Size = new System.Drawing.Size(178, 44);
            this.btn_Q4.TabIndex = 3;
            this.btn_Q4.Text = "Fire by lightning";
            this.btn_Q4.UseVisualStyleBackColor = true;
            this.btn_Q4.Click += new System.EventHandler(this.btn_Q4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(245, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 244);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 373);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Q4);
            this.Controls.Add(this.btn_Q3);
            this.Controls.Add(this.btn_Q2);
            this.Controls.Add(this.btn_Q1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Q1;
        private System.Windows.Forms.Button btn_Q2;
        private System.Windows.Forms.Button btn_Q3;
        private System.Windows.Forms.Button btn_Q4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

