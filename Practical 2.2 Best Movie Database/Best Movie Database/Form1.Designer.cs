namespace Best_Movie_Database
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
            this.button_AddMovie = new System.Windows.Forms.Button();
            this.button_DeleteMovie = new System.Windows.Forms.Button();
            this.button_SearchMovie = new System.Windows.Forms.Button();
            this.button_PrintAll = new System.Windows.Forms.Button();
            this.listBox_Movie = new System.Windows.Forms.ListBox();
            this.tb_SearchYear = new System.Windows.Forms.TextBox();
            this.tb_DeleteYear = new System.Windows.Forms.TextBox();
            this.tb_AddYear = new System.Windows.Forms.TextBox();
            this.tb_AddTitle = new System.Windows.Forms.TextBox();
            this.tb_Director = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddMovie
            // 
            this.button_AddMovie.Location = new System.Drawing.Point(21, 26);
            this.button_AddMovie.Name = "button_AddMovie";
            this.button_AddMovie.Size = new System.Drawing.Size(120, 47);
            this.button_AddMovie.TabIndex = 0;
            this.button_AddMovie.Text = "Add Movie";
            this.button_AddMovie.UseVisualStyleBackColor = true;
            this.button_AddMovie.Click += new System.EventHandler(this.button_AddMovie_Click);
            // 
            // button_DeleteMovie
            // 
            this.button_DeleteMovie.Location = new System.Drawing.Point(21, 126);
            this.button_DeleteMovie.Name = "button_DeleteMovie";
            this.button_DeleteMovie.Size = new System.Drawing.Size(120, 47);
            this.button_DeleteMovie.TabIndex = 1;
            this.button_DeleteMovie.Text = "Delete Movie";
            this.button_DeleteMovie.UseVisualStyleBackColor = true;
            this.button_DeleteMovie.Click += new System.EventHandler(this.button_DeleteMovie_Click);
            // 
            // button_SearchMovie
            // 
            this.button_SearchMovie.Location = new System.Drawing.Point(21, 250);
            this.button_SearchMovie.Name = "button_SearchMovie";
            this.button_SearchMovie.Size = new System.Drawing.Size(120, 47);
            this.button_SearchMovie.TabIndex = 2;
            this.button_SearchMovie.Text = "Search Movie";
            this.button_SearchMovie.UseVisualStyleBackColor = true;
            this.button_SearchMovie.Click += new System.EventHandler(this.button_SearchMovie_Click);
            // 
            // button_PrintAll
            // 
            this.button_PrintAll.Location = new System.Drawing.Point(21, 319);
            this.button_PrintAll.Name = "button_PrintAll";
            this.button_PrintAll.Size = new System.Drawing.Size(120, 47);
            this.button_PrintAll.TabIndex = 3;
            this.button_PrintAll.Text = "Print All";
            this.button_PrintAll.UseVisualStyleBackColor = true;
            this.button_PrintAll.Click += new System.EventHandler(this.button_PrintAll_Click);
            // 
            // listBox_Movie
            // 
            this.listBox_Movie.FormattingEnabled = true;
            this.listBox_Movie.Location = new System.Drawing.Point(160, 319);
            this.listBox_Movie.Name = "listBox_Movie";
            this.listBox_Movie.Size = new System.Drawing.Size(311, 186);
            this.listBox_Movie.TabIndex = 4;
            // 
            // tb_SearchYear
            // 
            this.tb_SearchYear.Location = new System.Drawing.Point(207, 256);
            this.tb_SearchYear.Name = "tb_SearchYear";
            this.tb_SearchYear.Size = new System.Drawing.Size(263, 20);
            this.tb_SearchYear.TabIndex = 5;
            // 
            // tb_DeleteYear
            // 
            this.tb_DeleteYear.Location = new System.Drawing.Point(206, 140);
            this.tb_DeleteYear.Name = "tb_DeleteYear";
            this.tb_DeleteYear.Size = new System.Drawing.Size(263, 20);
            this.tb_DeleteYear.TabIndex = 6;
            // 
            // tb_AddYear
            // 
            this.tb_AddYear.Location = new System.Drawing.Point(206, 26);
            this.tb_AddYear.Name = "tb_AddYear";
            this.tb_AddYear.Size = new System.Drawing.Size(263, 20);
            this.tb_AddYear.TabIndex = 7;
            // 
            // tb_AddTitle
            // 
            this.tb_AddTitle.Location = new System.Drawing.Point(206, 52);
            this.tb_AddTitle.Name = "tb_AddTitle";
            this.tb_AddTitle.Size = new System.Drawing.Size(263, 20);
            this.tb_AddTitle.TabIndex = 8;
            // 
            // tb_Director
            // 
            this.tb_Director.Location = new System.Drawing.Point(206, 78);
            this.tb_Director.Name = "tb_Director";
            this.tb_Director.Size = new System.Drawing.Size(263, 20);
            this.tb_Director.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Director";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Director);
            this.Controls.Add(this.tb_AddTitle);
            this.Controls.Add(this.tb_AddYear);
            this.Controls.Add(this.tb_DeleteYear);
            this.Controls.Add(this.tb_SearchYear);
            this.Controls.Add(this.listBox_Movie);
            this.Controls.Add(this.button_PrintAll);
            this.Controls.Add(this.button_SearchMovie);
            this.Controls.Add(this.button_DeleteMovie);
            this.Controls.Add(this.button_AddMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddMovie;
        private System.Windows.Forms.Button button_DeleteMovie;
        private System.Windows.Forms.Button button_SearchMovie;
        private System.Windows.Forms.Button button_PrintAll;
        private System.Windows.Forms.ListBox listBox_Movie;
        private System.Windows.Forms.TextBox tb_SearchYear;
        private System.Windows.Forms.TextBox tb_DeleteYear;
        private System.Windows.Forms.TextBox tb_AddYear;
        private System.Windows.Forms.TextBox tb_AddTitle;
        private System.Windows.Forms.TextBox tb_Director;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

