using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Reporter_Events
{
    public abstract class Observer
    {
        protected Subject subject;
        protected Control c;
        public Observer(Subject subject, Control c)
        {
            this.subject = subject;
            this.c = c;

            subject.UpdateEvent += new EventHandler(MakeProgress);

        }

        public abstract void MakeProgress(object o, EventArgs e);




    }
}
