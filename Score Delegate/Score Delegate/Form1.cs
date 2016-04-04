using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Delegate
{
    public partial class Form1 : Form
    {
        public delegate int ScorerDelegate(int correct, int incorrect);
        ScorerDelegate scoreComputer;
        private int correct;
        private int incorrect;

        public Form1()
        {
            InitializeComponent();
            scoreComputer = null;
            textBox1.Text = "8";
            textBox2.Text = "2";
        }

        public void computeScore(ScorerDelegate scoreDelegate)
        {
            int score = scoreDelegate(correct, incorrect);
            textBox3.Text = Convert.ToString(score);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correct = Convert.ToInt16(textBox1.Text);
            incorrect = Convert.ToInt16(textBox2.Text);

            if (rdo_Adult.Checked)
            {
                scoreComputer = new ScorerDelegate(Scorer.AdultScore);
            }
            if (rdo_Child.Checked)
            {
                scoreComputer = new ScorerDelegate(Scorer.ChildScore);
            }
            if (scoreComputer != null)
            {
                computeScore(scoreComputer);
            }
        }
    }
}
