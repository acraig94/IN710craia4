using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class BrownBear : Animal
    {
        public BrownBear()
        {
            name = "Brown Bear";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("brownbear.jpg");
        }
    }
}
