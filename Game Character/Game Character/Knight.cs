using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Knight: Character
    {
        public Knight(ListBox BattleBox, string Name)
        {
            name = Name;
            weaponType = new Knife();
            battleBox = BattleBox;
        }

        public override string Declaim()
        {
            return "I am a chivalrous Knight!";
        }

        
    }
}
