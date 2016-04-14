namespace PredicateLambda
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_Gen = new System.Windows.Forms.Button();
            this.btn_Even = new System.Windows.Forms.Button();
            this.btn_Less = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(63, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 384);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(444, 120);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 384);
            this.listBox2.TabIndex = 1;
            // 
            // btn_Gen
            // 
            this.btn_Gen.Location = new System.Drawing.Point(63, 44);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(246, 45);
            this.btn_Gen.TabIndex = 2;
            this.btn_Gen.Text = "Generate";
            this.btn_Gen.UseVisualStyleBackColor = true;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // btn_Even
            // 
            this.btn_Even.Location = new System.Drawing.Point(444, 12);
            this.btn_Even.Name = "btn_Even";
            this.btn_Even.Size = new System.Drawing.Size(246, 45);
            this.btn_Even.TabIndex = 3;
            this.btn_Even.Text = "Evens";
            this.btn_Even.UseVisualStyleBackColor = true;
            this.btn_Even.Click += new System.EventHandler(this.btn_Even_Click);
            // 
            // btn_Less
            // 
            this.btn_Less.Location = new System.Drawing.Point(444, 63);
            this.btn_Less.Name = "btn_Less";
            this.btn_Less.Size = new System.Drawing.Size(246, 45);
            this.btn_Less.TabIndex = 4;
            this.btn_Less.Text = "< 10";
            this.btn_Less.UseVisualStyleBackColor = true;
            this.btn_Less.Click += new System.EventHandler(this.btn_Less_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 546);
            this.Controls.Add(this.btn_Less);
            this.Controls.Add(this.btn_Even);
            this.Controls.Add(this.btn_Gen);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.Button btn_Even;
        private System.Windows.Forms.Button btn_Less;
    }
}

