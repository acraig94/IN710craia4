using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitAssignmentBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            TableBuilder tb = new TableBuilder();
            tb.CreateTables();
        }
    }
}
