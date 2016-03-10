namespace Game_Character
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTroll = new System.Windows.Forms.RadioButton();
            this.rdKnight = new System.Windows.Forms.RadioButton();
            this.rdQueen = new System.Windows.Forms.RadioButton();
            this.rdKing = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.characterBattleLB = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBow = new System.Windows.Forms.RadioButton();
            this.rdKnife = new System.Windows.Forms.RadioButton();
            this.rdSword = new System.Windows.Forms.RadioButton();
            this.characterListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAddCharacter);
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(18, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 260);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTroll);
            this.groupBox1.Controls.Add(this.rdKnight);
            this.groupBox1.Controls.Add(this.rdQueen);
            this.groupBox1.Controls.Add(this.rdKing);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(408, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(242, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Type";
            // 
            // rdTroll
            // 
            this.rdTroll.AutoSize = true;
            this.rdTroll.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTroll.Location = new System.Drawing.Point(19, 159);
            this.rdTroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTroll.Name = "rdTroll";
            this.rdTroll.Size = new System.Drawing.Size(100, 35);
            this.rdTroll.TabIndex = 3;
            this.rdTroll.TabStop = true;
            this.rdTroll.Text = "Troll";
            this.rdTroll.UseVisualStyleBackColor = true;
            // 
            // rdKnight
            // 
            this.rdKnight.AutoSize = true;
            this.rdKnight.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnight.Location = new System.Drawing.Point(19, 120);
            this.rdKnight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKnight.Name = "rdKnight";
            this.rdKnight.Size = new System.Drawing.Size(131, 35);
            this.rdKnight.TabIndex = 2;
            this.rdKnight.TabStop = true;
            this.rdKnight.Text = "Knight";
            this.rdKnight.UseVisualStyleBackColor = true;
            // 
            // rdQueen
            // 
            this.rdQueen.AutoSize = true;
            this.rdQueen.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQueen.Location = new System.Drawing.Point(19, 81);
            this.rdQueen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdQueen.Name = "rdQueen";
            this.rdQueen.Size = new System.Drawing.Size(117, 35);
            this.rdQueen.TabIndex = 1;
            this.rdQueen.TabStop = true;
            this.rdQueen.Text = "Queen";
            this.rdQueen.UseVisualStyleBackColor = true;
            // 
            // rdKing
            // 
            this.rdKing.AutoSize = true;
            this.rdKing.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKing.Location = new System.Drawing.Point(19, 42);
            this.rdKing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKing.Name = "rdKing";
            this.rdKing.Size = new System.Drawing.Size(104, 35);
            this.rdKing.TabIndex = 0;
            this.rdKing.TabStop = true;
            this.rdKing.Text = "King";
            this.rdKing.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 40);
            this.txtName.TabIndex = 9;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.Location = new System.Drawing.Point(30, 28);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(323, 49);
            this.btnAddCharacter.TabIndex = 8;
            this.btnAddCharacter.Text = "Create New Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBattle);
            this.panel2.Controls.Add(this.characterBattleLB);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(18, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 520);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "To Battle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Two Combatants";
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(333, 52);
            this.btnBattle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(326, 54);
            this.btnBattle.TabIndex = 22;
            this.btnBattle.Text = "Battle!";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // characterBattleLB
            // 
            this.characterBattleLB.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBattleLB.FormattingEnabled = true;
            this.characterBattleLB.Location = new System.Drawing.Point(17, 122);
            this.characterBattleLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterBattleLB.Name = "characterBattleLB";
            this.characterBattleLB.Size = new System.Drawing.Size(300, 354);
            this.characterBattleLB.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(333, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 345);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.characterListBox);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(724, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 806);
            this.panel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBow);
            this.groupBox2.Controls.Add(this.rdKnife);
            this.groupBox2.Controls.Add(this.rdSword);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(242, 165);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Weapon";
            // 
            // rdBow
            // 
            this.rdBow.AutoSize = true;
            this.rdBow.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBow.Location = new System.Drawing.Point(19, 120);
            this.rdBow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBow.Name = "rdBow";
            this.rdBow.Size = new System.Drawing.Size(95, 35);
            this.rdBow.TabIndex = 2;
            this.rdBow.TabStop = true;
            this.rdBow.Text = "Bow";
            this.rdBow.UseVisualStyleBackColor = true;
            // 
            // rdKnife
            // 
            this.rdKnife.AutoSize = true;
            this.rdKnife.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnife.Location = new System.Drawing.Point(19, 81);
            this.rdKnife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKnife.Name = "rdKnife";
            this.rdKnife.Size = new System.Drawing.Size(112, 35);
            this.rdKnife.TabIndex = 1;
            this.rdKnife.TabStop = true;
            this.rdKnife.Text = "Knife";
            this.rdKnife.UseVisualStyleBackColor = true;
            // 
            // rdSword
            // 
            this.rdSword.AutoSize = true;
            this.rdSword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSword.Location = new System.Drawing.Point(19, 42);
            this.rdSword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdSword.Name = "rdSword";
            this.rdSword.Size = new System.Drawing.Size(120, 35);
            this.rdSword.TabIndex = 0;
            this.rdSword.TabStop = true;
            this.rdSword.Text = "Sword";
            this.rdSword.UseVisualStyleBackColor = true;
            // 
            // characterListBox
            // 
            this.characterListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.Location = new System.Drawing.Point(25, 68);
            this.characterListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(300, 354);
            this.characterListBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 736);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 54);
            this.button1.TabIndex = 25;
            this.button1.Text = "Change Weapon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 848);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Battle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTroll;
        private System.Windows.Forms.RadioButton rdKnight;
        private System.Windows.Forms.RadioButton rdQueen;
        private System.Windows.Forms.RadioButton rdKing;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.CheckedListBox characterBattleLB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox characterListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBow;
        private System.Windows.Forms.RadioButton rdKnife;
        private System.Windows.Forms.RadioButton rdSword;
    }
}

