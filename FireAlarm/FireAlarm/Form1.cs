using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject subject;
        InstructionsObserver io;
        BellObserver bo;
        public Form1()
        {
            InitializeComponent();

            subject = new FireAlarmSubject();
            io = new InstructionsObserver(subject);
            bo = new BellObserver(subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EFireCategory fc = EFireCategory.NULL;

            if (rdo_Inferno.Checked)
            {
                fc = EFireCategory.INFERNO;
            }
            if (rdo_Serious.Checked)
            {
                fc = EFireCategory.SERIOUS;
            }
            if (rdo_Minor.Checked)
            {
                fc = EFireCategory.MINOR;
            }
            if (fc != EFireCategory.NULL)
            {
                subject.onFireEvent(fc);
            }
                        
            Console.WriteLine(fc);
        }
    }
}
