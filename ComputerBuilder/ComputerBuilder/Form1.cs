using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        private IMachineType currMachineMaker;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (rdo_Game.Checked)
                currMachineMaker = new GameMachineMaker();
            else if (rdo_Business.Checked)
                currMachineMaker = new BusinessMachineMaker();
            else if (rdo_Laptop.Checked)
                currMachineMaker = new LaptopMachineMaker();
            else
                currMachineMaker = new MultimediaMachineMaker();

            MachineSpecPrinter currSpecPrinter = new MachineSpecPrinter(currMachineMaker, listBox1);
            currSpecPrinter.printSpec();
        }
    }
}
