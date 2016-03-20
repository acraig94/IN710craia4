using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_And_Match
{
    public class ImagePrinter
    {
        private HeadMaker headMaker;
        private BodyMaker bodyMaker;
        private LegMaker legMaker;

        private ComboBox cbH;
        private ComboBox cbB;
        private ComboBox cbL;

        private PictureBox pbH;
        private PictureBox pbB;
        private PictureBox pbL;

        public ImagePrinter(ComboBox cbH, ComboBox cbB, ComboBox cbL, PictureBox pbH, PictureBox pbB, PictureBox pbL)
        {
            headMaker = new HeadMaker();
            bodyMaker = new BodyMaker();
            legMaker = new LegMaker();

            this.cbH = cbH;
            this.cbB = cbB;
            this.cbL = cbL;

            this.pbH = pbH;
            this.pbB = pbB;
            this.pbL = pbL;
        }

        public void printMonster()
        {
            pbH.Image = headMaker.makeBodyPart(cbH.Text.ToString());
            pbH.SizeMode = PictureBoxSizeMode.Zoom;

            pbB.Image = bodyMaker.makeBodyPart(cbB.Text.ToString());
            pbB.SizeMode = PictureBoxSizeMode.Zoom;

            pbL.Image = legMaker.makeBodyPart(cbL.Text.ToString());
            pbL.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
