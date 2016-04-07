using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BellObserver : Observer
    {
        [DllImport("kernal32.dll")]
        public static extern bool Beep(int freq, int duration);

        public BellObserver(FireAlarmSubject subject) :base(subject)
        {
        }

        public override void FAHM(object fireSubject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {// beeps commented out . getting dll not found error
                case EFireCategory.MINOR:
                    //Beep(800, 500);
                    break;
                case EFireCategory.SERIOUS:
                    //Beep(1000, 500);
                    break;
                case EFireCategory.INFERNO:
                    //Beep(1200, 500);
                    break;
            }

        }
    }
}
