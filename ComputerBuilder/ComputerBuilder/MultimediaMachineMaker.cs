using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class MultimediaMachineMaker : IMachineType
    {
        public CPU makeCPU()
        {
            CPU cpu = new CPU("Dual Core 2.2 GHz", 250);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            GraphicsCard gc = new GraphicsCard("GeForce 285", 711);
            return gc;
        }

        public Memory makeMemory()
        {
            Memory m = new Memory("12GB RAM", 300);
            return m;
        }

        public Monitor makeMonitor()
        {
            Monitor m = new Monitor("24\" Widescreen", 230);
            return m;
        }
    }
}
