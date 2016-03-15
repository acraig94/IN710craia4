using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class Spider : Animal
    {
        public Spider()
        {
            name = "Spider";
            family = "Carnivore";
            food = "Flys";
            image = new Bitmap("spider.jpg");
        }
    }
}
