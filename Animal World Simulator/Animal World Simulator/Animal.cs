using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public abstract class Animal
    {
        protected string name;
        protected string family;
        protected string food;
        protected Bitmap image;
        public Bitmap Image
        {
            get { return image; }
        }

        public override string ToString()
        {
            return "I am a " + name + ". I am a " + family + ". I eat " + food + ".";
        }
        

    }
}
