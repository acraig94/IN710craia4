using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public abstract class Character
    {
        protected string name;
        protected Weapon weaponType;
        protected ListBox battleBox;
                
        public string StateName()
        {
            return "My name is " + name + "!";
        }

        public abstract string Declaim();

        public string useWeapon()
        {
            return weaponType.ToString();
        }

        public string getName()
        {
            return name;
        }

        public void setWeapon(Weapon w)
        {
            weaponType = w;
        }

        public void printAll()
        {
            battleBox.Items.Add(StateName());
            battleBox.Items.Add(Declaim());
            battleBox.Items.Add(useWeapon());
        }






    }
}
