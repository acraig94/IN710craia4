using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public class MachineSpecPrinter
    {
        private IMachineType machineMaker;
        private ListBox displayBox;

        public MachineSpecPrinter(IMachineType machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        public void printSpec()
        {
            CPU currCPU = machineMaker.makeCPU();
            Memory currMemory = machineMaker.makeMemory();
            GraphicsCard currGraphicsCard = machineMaker.makeGraphicsCard();
            Monitor currMonitor = machineMaker.makeMonitor();

            double totalPrice = currCPU.Price + currMemory.Price + currGraphicsCard.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\t\tComponent");
            displayBox.Items.Add("--------------------------------");

            displayBox.Items.Add(currCPU.ToString());
            displayBox.Items.Add(currMemory.ToString());
            displayBox.Items.Add(currGraphicsCard.ToString());
            displayBox.Items.Add(currMonitor.ToString());

            displayBox.Items.Add("--------------------------------");
            displayBox.Items.Add("Total Price: " + totalPrice.ToString());

        }

    }
}
