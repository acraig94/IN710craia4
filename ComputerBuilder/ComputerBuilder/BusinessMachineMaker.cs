using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class BusinessMachineMaker : IMachineType
    {
        public CPU makeCPU()
        {
            CPU cpu = new CPU("Dual Core 1.4 GHz", 129);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            GraphicsCard gc = new GraphicsCard("Radeon HD", 378);
            return gc;
        }

        public Memory makeMemory()
        {
            Memory m = new Memory("2GB RAM", 50);
            return m;
        }

        public Monitor makeMonitor()
        {
            Monitor m = new Monitor("21\" Widescreen", 330);
            return m;
        }
    }
}
