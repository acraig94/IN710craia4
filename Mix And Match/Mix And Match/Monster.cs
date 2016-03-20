using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_And_Match
{
    public enum EType { Vampire, Frankenstein, Fairy, Skeleton, Witch, Werewolf};

    public class Monster
    {
        private string head;
        public string Head
        {
            get { return head; }
        }

        private string body;
        public string Body
        {
            get { return body; }
        }

        private string leg;
        public string Leg
        {
            get { return leg; }
        }

        private EType type;
        public EType Type { get {return type;} }

        public Monster(EType type)
        {
            this.type = type;
            head = "images/" + type.ToString() + "_0.png";
            body = "images/" + type.ToString() + "_1.png";
            leg = "images/" + type.ToString() + "_2.png";
        }



    }
}
