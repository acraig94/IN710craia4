namespace Encryption
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
            this.bttnEncrpyt = new System.Windows.Forms.Button();
            this.bttnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoStringReverse = new System.Windows.Forms.RadioButton();
            this.rdoROT17 = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnEncrpyt
            // 
            this.bttnEncrpyt.Location = new System.Drawing.Point(441, 51);
            this.bttnEncrpyt.Name = "bttnEncrpyt";
            this.bttnEncrpyt.Size = new System.Drawing.Size(167, 51);
            this.bttnEncrpyt.TabIndex = 0;
            this.bttnEncrpyt.Text = "Encrypt";
            this.bttnEncrpyt.UseVisualStyleBackColor = true;
            this.bttnEncrpyt.Click += new System.EventHandler(this.bttnEncrpyt_Click);
            // 
            // bttnDecrypt
            // 
            this.bttnDecrypt.Location = new System.Drawing.Point(628, 51);
            this.bttnDecrypt.Name = "bttnDecrypt";
            this.bttnDecrypt.Size = new System.Drawing.Size(167, 51);
            this.bttnDecrypt.TabIndex = 1;
            this.bttnDecrypt.Text = "Decrypt";
            this.bttnDecrypt.UseVisualStyleBackColor = true;
            this.bttnDecrypt.Click += new System.EventHandler(this.bttnDecrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoStringReverse);
            this.groupBox1.Controls.Add(this.rdoROT17);
            this.groupBox1.Location = new System.Drawing.Point(68, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // rdoStringReverse
            // 
            this.rdoStringReverse.AutoSize = true;
            this.rdoStringReverse.Location = new System.Drawing.Point(21, 80);
            this.rdoStringReverse.Name = "rdoStringReverse";
            this.rdoStringReverse.Size = new System.Drawing.Size(132, 24);
            this.rdoStringReverse.TabIndex = 1;
            this.rdoStringReverse.TabStop = true;
            this.rdoStringReverse.Text = "String reverse";
            this.rdoStringReverse.UseVisualStyleBackColor = true;
            // 
            // rdoROT17
            // 
            this.rdoROT17.AutoSize = true;
            this.rdoROT17.Location = new System.Drawing.Point(21, 40);
            this.rdoROT17.Name = "rdoROT17";
            this.rdoROT17.Size = new System.Drawing.Size(85, 24);
            this.rdoROT17.TabIndex = 0;
            this.rdoROT17.TabStop = true;
            this.rdoROT17.Text = "ROT17";
            this.rdoROT17.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(172, 244);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(392, 26);
            this.tbInput.TabIndex = 3;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(172, 310);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(392, 26);
            this.tbOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttnDecrypt);
            this.Controls.Add(this.bttnEncrpyt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnEncrpyt;
        private System.Windows.Forms.Button bttnDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoStringReverse;
        private System.Windows.Forms.RadioButton rdoROT17;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

