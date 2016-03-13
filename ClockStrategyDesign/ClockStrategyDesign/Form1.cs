using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockStrategyDesign
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private AnalogMachine aClock;
        private DigitalClock dClock;       

        public Form1()
        {
            InitializeComponent();
            timer = timer1;
            timer.Interval = 1000;
            timer.Start();
            aClock = new AnalogMachine(analogClock1);
            dClock = new DigitalClock(digitalClockLabel, timer);
            rdoDigital.Checked = true;
        }

        private void bttn_Start_Click(object sender, EventArgs e)
        {
            if (rdoDigital.Checked)
            {
                dClock.On();
            }
            else
            {
                aClock.On();
            }
        }

        private void bttn_Stop_Click(object sender, EventArgs e)
        {
            if (rdoDigital.Checked)
            {
                dClock.Off();
            }
            else
            {
                aClock.Off();
            }
        }

        private void rdoDigital_CheckedChanged(object sender, EventArgs e)
        {
            dClock.ShowClock();
            aClock.HideClock(); 
        }

        private void rdoAnalog_CheckedChanged(object sender, EventArgs e)
        {
            aClock.ShowClock();
            dClock.HideClock();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdoAnalog.Checked)
            {
                aClock.UpdateTimeDisplay();
            }
            else
            {
                dClock.UpdateTimeDisplay();
                digitalClockLabel.Text = dClock.getLabel();
            }
        }
    }
}
