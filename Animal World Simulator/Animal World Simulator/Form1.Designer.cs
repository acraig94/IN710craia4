namespace Animal_World_Simulator
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
            this.btn_NA = new System.Windows.Forms.Button();
            this.btn_AUS = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Africa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NA
            // 
            this.btn_NA.Location = new System.Drawing.Point(314, 422);
            this.btn_NA.Name = "btn_NA";
            this.btn_NA.Size = new System.Drawing.Size(240, 71);
            this.btn_NA.TabIndex = 0;
            this.btn_NA.Text = "North America";
            this.btn_NA.UseVisualStyleBackColor = true;
            this.btn_NA.Click += new System.EventHandler(this.btn_NA_Click);
            // 
            // btn_AUS
            // 
            this.btn_AUS.Location = new System.Drawing.Point(614, 422);
            this.btn_AUS.Name = "btn_AUS";
            this.btn_AUS.Size = new System.Drawing.Size(240, 71);
            this.btn_AUS.TabIndex = 1;
            this.btn_AUS.Text = "Australia";
            this.btn_AUS.UseVisualStyleBackColor = true;
            this.btn_AUS.Click += new System.EventHandler(this.btn_AUS_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(302, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 324);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Africa
            // 
            this.btn_Africa.Location = new System.Drawing.Point(314, 499);
            this.btn_Africa.Name = "btn_Africa";
            this.btn_Africa.Size = new System.Drawing.Size(240, 71);
            this.btn_Africa.TabIndex = 3;
            this.btn_Africa.Text = "Africa";
            this.btn_Africa.UseVisualStyleBackColor = true;
            this.btn_Africa.Click += new System.EventHandler(this.btn_Africa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 683);
            this.Controls.Add(this.btn_Africa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_AUS);
            this.Controls.Add(this.btn_NA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NA;
        private System.Windows.Forms.Button btn_AUS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Africa;
    }
}

