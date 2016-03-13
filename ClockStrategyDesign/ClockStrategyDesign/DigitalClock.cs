using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockStrategyDesign
{
    class DigitalClock : IClock
    {
        private Label timeDisplayLabel { set; get; }
        private Timer timer;

        public DigitalClock(Label TDL, Timer Timer)
        {
            timeDisplayLabel = TDL;
            timer = Timer;        
        }

        public void HideClock()
        {
            timeDisplayLabel.Visible = false;
        }

        public void Off()
        {
            timer.Stop();
        }

        public void On()
        {
            timer.Start();
        }

        public void ShowClock()
        {
            timeDisplayLabel.Visible = true;
        }

        public void UpdateTimeDisplay()
        {
            timeDisplayLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        public string getLabel()
        {
            return timeDisplayLabel.Text;
        }
    }
}
