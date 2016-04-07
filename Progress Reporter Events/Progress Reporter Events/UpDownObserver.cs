using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Reporter_Events
{
    public class UpDownObserver : Observer
    {
        private NumericUpDown n;

        public UpDownObserver(Subject subject, Control c) :base(subject, c){ n = (NumericUpDown)c; }

        public override void MakeProgress(object o, EventArgs e)
        {
            n.Value++;
            Application.DoEvents();
        }
    }
}
