using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_And_Match
{
    public class LegMaker : IMonsterType
    {
        public Bitmap makeBodyPart(string monsterType)
        {
            EType legType = (EType)Enum.Parse(typeof(EType), monsterType);
            Monster m = new Monster(legType);
            Bitmap imageLeg = new Bitmap(m.Leg);
            return imageLeg;
        }
    }
}
