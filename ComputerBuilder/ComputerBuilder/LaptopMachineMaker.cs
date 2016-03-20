using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class LaptopMachineMaker : IMachineType
    {
        public CPU makeCPU()
        {
            CPU cpu = new CPU("Intel Core i5 2.2GHz", 210);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            GraphicsCard gc = new GraphicsCard("Intel HD Graphics", 390);
            return gc;
        }

        public Memory makeMemory()
        {
            Memory m = new Memory("8GB RAM", 50);
            return m;
        }

        public Monitor makeMonitor()
        {
            Monitor m = new Monitor("13\" Widescreen", 230);
            return m;
        } 

    }
}
