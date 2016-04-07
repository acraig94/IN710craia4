using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Reporter_Events
{
    public partial class Form1 : Form
    {
        Subject subject;
        UpDownObserver udo;
        ProgressBarObserver pbo;
        TrackBarObserver tbo;

        public Form1()
        {
            InitializeComponent();
            subject = new Subject();
            udo = new UpDownObserver(subject, numericUpDown1);
            pbo = new ProgressBarObserver(subject, progressBar1);
            tbo = new TrackBarObserver(subject, trackBar1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject.SlowMethod();
        }
    }
}
