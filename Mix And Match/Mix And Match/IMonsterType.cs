using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_And_Match
{
    public interface IMonsterType
    {
        Bitmap makeBodyPart(string monsterType);
    }


}
