using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Reporter_Events
{
    public class ProgressBarObserver : Observer
    {
        private ProgressBar p;

        public ProgressBarObserver(Subject subject, Control c) :base(subject, c){ p = (ProgressBar)c; }

        public override void MakeProgress(object o, EventArgs e)
        {
            p.PerformStep();
        }
    }
}
