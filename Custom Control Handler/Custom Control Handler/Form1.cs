using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Control_Handler
{
    public partial class Form1 : Form
    {
        CustomHandler handle1;
        CustomHandler handle2;
        CustomHandler handle3;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            handle1 = new CustomHandler(button1, rand.Next(100));
            handle2 = new CustomHandler(button1, rand.Next(100));
            handle3 = new CustomHandler(button1, rand.Next(100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forms handler");
        
        }
    }
}
