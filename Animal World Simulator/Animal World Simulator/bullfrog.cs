using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class Bullfrog : Animal
    {
        public Bullfrog()
        {
            name = "Bullfrog";
            family = "Carnivore";
            food = "Insects";
            image = new Bitmap("bullfrog.jpg");
        }
    }
}
