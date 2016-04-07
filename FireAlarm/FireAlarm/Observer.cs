using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class Observer
    {
        protected FireAlarmSubject subject;

        public Observer(FireAlarmSubject subject)
        {
            this.subject = subject;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FAHM);
            subject.FireEvent += handler;
        }

        public abstract void FAHM(object fireSubject, FireAlarmEventArgs fe);1

    }
}
