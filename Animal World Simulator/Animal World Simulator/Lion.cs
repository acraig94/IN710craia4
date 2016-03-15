using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class Lion : Animal
    {
        public Lion()
        {
            name = "Lion";
            family = "Carnivore";
            food = "Zebras";
            image = new Bitmap("bison.jpg");
        }
    }
}
