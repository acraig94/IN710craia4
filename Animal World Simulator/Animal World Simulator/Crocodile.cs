using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Large Animals";
            image = new Bitmap("crocodile.jpg");
        }
    }
}
