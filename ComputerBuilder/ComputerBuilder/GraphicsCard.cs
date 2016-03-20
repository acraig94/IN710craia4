using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class GraphicsCard : Component
    {
        public GraphicsCard(string Model, double Price)
        {
            model = Model;
            price = Price;
        }
    }
}
