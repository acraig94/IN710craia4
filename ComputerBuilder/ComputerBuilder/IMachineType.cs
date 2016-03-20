using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public interface IMachineType
    {
        CPU makeCPU();
        Memory makeMemory();
        GraphicsCard makeGraphicsCard();
        Monitor makeMonitor();
    }
}
