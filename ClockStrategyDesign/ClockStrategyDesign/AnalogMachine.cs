using AnalogClockControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockStrategyDesign
{
    class AnalogMachine : IClock
    {
        private AnalogClock clock;

        public AnalogMachine(AnalogClock Clock)
        {
            clock = Clock;
        }

        public void HideClock()
        {
            clock.Visible = false;
        }

        public void Off()
        {
            clock.Stop();
        }

        public void On()
        {
            clock.Start();
        }

        public void ShowClock()
        {
            clock.Visible = true;
        }

        public void UpdateTimeDisplay()
        {
            clock.Update();
        }
    }
}
