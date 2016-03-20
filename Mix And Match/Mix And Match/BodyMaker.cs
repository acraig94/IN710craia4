using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_And_Match
{
    public class BodyMaker : IMonsterType
    {
        public Bitmap makeBodyPart(string monsterType)
        {
            EType bodyType = (EType)Enum.Parse(typeof(EType), monsterType);
            Monster m = new Monster(bodyType);
            Bitmap imageBody = new Bitmap(m.Body);
            return imageBody;
        }
    }
}
