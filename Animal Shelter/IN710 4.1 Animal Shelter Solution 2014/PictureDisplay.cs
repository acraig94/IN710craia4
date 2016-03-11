using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay : IDisplay
    {
        List<PictureBox> pictureboxlist;

        public PictureDisplay(List<PictureBox> PictureBoxList)
        {
            pictureboxlist = PictureBoxList;
        }

        public void clearDisplay()
        {
            foreach (PictureBox item in pictureboxlist)
            {
                item.Image = null;
            }
        }

        public void displayCritterList(List<Critter> critterList)
        {
            int listCount = 0;
            foreach (Critter item in critterList)
            {
                pictureboxlist[listCount].ImageLocation = item.ImageFileName;
                listCount++;
            }
        }
    }
}
