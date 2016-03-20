namespace ComputerBuilder
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
            this.btn_Find = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Game = new System.Windows.Forms.RadioButton();
            this.rdo_Business = new System.Windows.Forms.RadioButton();
            this.rdo_Multimedia = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdo_Laptop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(12, 86);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(200, 30);
            this.btn_Find.TabIndex = 0;
            this.btn_Find.Text = "Find Specs";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Laptop);
            this.groupBox1.Controls.Add(this.rdo_Multimedia);
            this.groupBox1.Controls.Add(this.rdo_Business);
            this.groupBox1.Controls.Add(this.rdo_Game);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Type";
            // 
            // rdo_Game
            // 
            this.rdo_Game.AutoSize = true;
            this.rdo_Game.Location = new System.Drawing.Point(16, 42);
            this.rdo_Game.Name = "rdo_Game";
            this.rdo_Game.Size = new System.Drawing.Size(78, 24);
            this.rdo_Game.TabIndex = 0;
            this.rdo_Game.TabStop = true;
            this.rdo_Game.Text = "Game";
            this.rdo_Game.UseVisualStyleBackColor = true;
            // 
            // rdo_Business
            // 
            this.rdo_Business.AutoSize = true;
            this.rdo_Business.Location = new System.Drawing.Point(16, 72);
            this.rdo_Business.Name = "rdo_Business";
            this.rdo_Business.Size = new System.Drawing.Size(99, 24);
            this.rdo_Business.TabIndex = 1;
            this.rdo_Business.TabStop = true;
            this.rdo_Business.Text = "Business";
            this.rdo_Business.UseVisualStyleBackColor = true;
            // 
            // rdo_Multimedia
            // 
            this.rdo_Multimedia.AutoSize = true;
            this.rdo_Multimedia.Location = new System.Drawing.Point(16, 102);
            this.rdo_Multimedia.Name = "rdo_Multimedia";
            this.rdo_Multimedia.Size = new System.Drawing.Size(110, 24);
            this.rdo_Multimedia.TabIndex = 2;
            this.rdo_Multimedia.TabStop = true;
            this.rdo_Multimedia.Text = "Multimedia";
            this.rdo_Multimedia.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(241, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 324);
            this.listBox1.TabIndex = 2;
            // 
            // rdo_Laptop
            // 
            this.rdo_Laptop.AutoSize = true;
            this.rdo_Laptop.Location = new System.Drawing.Point(16, 132);
            this.rdo_Laptop.Name = "rdo_Laptop";
            this.rdo_Laptop.Size = new System.Drawing.Size(84, 24);
            this.rdo_Laptop.TabIndex = 3;
            this.rdo_Laptop.TabStop = true;
            this.rdo_Laptop.Text = "Laptop";
            this.rdo_Laptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 537);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Find);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Multimedia;
        private System.Windows.Forms.RadioButton rdo_Business;
        private System.Windows.Forms.RadioButton rdo_Game;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdo_Laptop;
    }
}

