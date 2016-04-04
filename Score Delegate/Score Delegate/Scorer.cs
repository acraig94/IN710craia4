using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_Delegate
{
    public class Scorer
    {
        public static int AdultScore(int correct, int incorrect)
        {
            return (correct * 10) - incorrect;
        }
        public static int ChildScore(int correct, int incorrect)
        {
            return correct * 15;
        }

        public Scorer() { }

        

    }
}
