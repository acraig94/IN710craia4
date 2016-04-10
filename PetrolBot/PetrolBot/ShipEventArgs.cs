using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class ShipEventArgs
    {
        private int xPos;
        public int XPos { get { return xPos; } set { xPos = value; } }
        private int yPos;
        public int YPos { get { return yPos; } set { yPos = value; } }

        public ShipEventArgs(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

    }
}
