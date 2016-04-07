using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Reporter_Events
{
    public class TrackBarObserver : Observer
    {
        private TrackBar t;

        public TrackBarObserver(Subject subject, Control c) :base(subject, c){ t = (TrackBar)c; }

        public override void MakeProgress(object o, EventArgs e)
        {
            t.Value++;
        }
    }
}
