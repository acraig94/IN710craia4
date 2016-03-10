using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class King : Character
    {
        
        public King(ListBox Battlebox, string Name)
        {
            name = Name;
            weaponType = new Sword();
            battleBox = Battlebox;
        }

        public override string Declaim()
        {
            return "I am the most mighty of Kings!";
        }

        
    }
}
