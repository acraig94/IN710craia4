using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_World_Simulator
{
    public partial class Form1 : Form
    {
        private const int NAANIMALCOUNT = 4;
        private const int AUSANIMALCOUNT = 4;
        private const int AFANIMALCOUNT = 2;

        private Random rGen;
        private Graphics formCanvas;
        private NorthAmerica northAmerica;
        private Australia australia;
        private Africa africa;

        public Form1()
        {
            InitializeComponent();

            rGen = new Random();
            formCanvas = this.CreateGraphics();

            northAmerica = new NorthAmerica(listBox1, rGen, NAANIMALCOUNT, formCanvas);
            australia = new Australia(listBox1, rGen, AUSANIMALCOUNT, formCanvas);
            africa = new Africa(listBox1, rGen, AFANIMALCOUNT, formCanvas);
        }

        private void btn_NA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            northAmerica.runSimulation();
        }

        private void btn_AUS_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            australia.runSimulation();
        }

        private void btn_Africa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            africa.runSimulation();
        }
    }
}
