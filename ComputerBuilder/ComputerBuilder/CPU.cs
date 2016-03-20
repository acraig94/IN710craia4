using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class CPU : Component
    {
        public CPU(string Model, double Price)
        {
            model = Model;
            price = Price;
        }
    }
}
