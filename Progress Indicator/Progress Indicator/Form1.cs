using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Progress_Indicator
{
    public partial class Form1 : Form
    { 
        public delegate void FeedBackDelegate();

        public Form1()
        {
            InitializeComponent();
            //FeedBackDelegate feedBackDelegate = new FeedBackDelegate();
        }

        private void updateSpin()
        {
            numericUpDown1.Value++;
        }

        private void updateProgressBar()
        {
            progressBar1.PerformStep();
        }

        private void updateTrack()
        {
            trackBar1.Value++;
        }

        private void slowMethod(FeedBackDelegate feedback)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);

                feedback();
            }
            
        }

        private void resetControls()
        {
            trackBar1.Value = 0;
            progressBar1.Value = 0;
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedBackDelegate feedBackDelegate = null;
            resetControls();
            if (rdo_PBar.Checked)
            {
                feedBackDelegate = new FeedBackDelegate(updateProgressBar);
            }
            if (rdo_TrackBar.Checked)
            {
                feedBackDelegate = new FeedBackDelegate(updateTrack);
            }
            if (rdo_spin.Checked)
            {
                feedBackDelegate = new FeedBackDelegate(updateSpin);
            }
            if (feedBackDelegate != null)
            {
                slowMethod(feedBackDelegate);
            }

        }
    }
}
