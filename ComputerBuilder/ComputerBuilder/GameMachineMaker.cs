using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class GameMachineMaker : IMachineType
    {
        public CPU makeCPU()
        {
            CPU cpu = new CPU("Quad Core 3.8 GHz", 450);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            GraphicsCard gc = new GraphicsCard("Nvidia GTX 970 ", 1100);
            return gc;
        }

        public Memory makeMemory()
        {
            Memory m = new Memory("16GB RAM", 400);
            return m;
        }

        public Monitor makeMonitor()
        {
            Monitor m = new Monitor("27\" Widescreen", 530);
            return m;
        }
    }
}
