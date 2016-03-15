using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class Koala : Animal
    {
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Leafs";
            image = new Bitmap("koala.jpg");
        }
    }
}
