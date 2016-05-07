using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_Linq
{
    public partial class Form1 : Form
    {
        dbQueries queries;
        public Form1()
        {
            InitializeComponent();
            queries = new dbQueries();
        }

        private void btn_Q1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Average intensity is " + queries.avgIntensity());
        }

        private void btn_Q2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string f in queries.ThreeLargestFires())
            {
                listBox1.Items.Add(f);
            }
            
        }

        private void btn_Q3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string p in queries.DisplayPictureInfo())
            {
                listBox1.Items.Add(p);
            }
        }

        private void btn_Q4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string f in queries.FireByLightning())
            {
                listBox1.Items.Add(f);
            }
        }
    }
}
