using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Reporter_Events
{
    public class Subject
    {
        public event EventHandler UpdateEvent;

        public void OnUpdateEvent()
        {
            if (UpdateEvent != null)
            {
                UpdateEvent(this, null);
            }

        }

        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
    }
}
