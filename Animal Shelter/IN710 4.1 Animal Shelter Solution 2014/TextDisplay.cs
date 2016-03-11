using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay : IDisplay
    {
        private ListBox listbox_critter;

        public TextDisplay(ListBox ListBox_Critter)
        {
            listbox_critter = ListBox_Critter;
        }
         
        public void clearDisplay()
        {
            listbox_critter.Items.Clear();
        }

        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter item in critterList)
            {
                listbox_critter.Items.Add(item.Name);
            }
        }
    }
}
