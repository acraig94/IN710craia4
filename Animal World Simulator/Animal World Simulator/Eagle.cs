using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Rabits";
            image = new Bitmap("eagle.jpg");
        }
    }
}
