using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Weapon
    {
        protected string type;
        protected string action;

        public override String ToString()
        {
            return "I " + action + " with my " + type + "!";
        }
    }
}
