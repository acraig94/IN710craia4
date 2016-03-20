using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public abstract class Component
    {

        protected double price;
        public double Price
        {
            get { return price; }
        }

        protected string model;
        public string Model
        {
            get { return model; }
        }

        public Component()
        {

        }

        public override string ToString()
        {
            return model + "\t\t" + price;
        }


    }
}
