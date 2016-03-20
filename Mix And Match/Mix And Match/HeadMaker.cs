using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_And_Match
{
    public class HeadMaker : IMonsterType
    {
        public Bitmap makeBodyPart(string monsterType)
        {
            EType headType = (EType)Enum.Parse(typeof(EType), monsterType);
            Monster m = new Monster(headType);
            Bitmap imageHead = new Bitmap(m.Head);     
            return imageHead;
        }
    }
}
