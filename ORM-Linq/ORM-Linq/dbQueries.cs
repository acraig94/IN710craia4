using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Linq
{
    public class dbQueries
    {
        private LightningDbDataContext db;

        public dbQueries()
        {
            db = new LightningDbDataContext();   
        }

        public double avgIntensity()
        {
            var strikes = from l in db.tblStrikes
                          select l.strikeIntensity;
            return strikes.Average();
        }

        public List<string> ThreeLargestFires()
        {
            var fires = (from f in db.tblFires
                        orderby f.fireArea descending
                        select f).Take(3);
            List<String> fireList = new List<string>();
            foreach (var f in fires)
            {
                fireList.Add(f.fireDate + ", " + f.fireLatitude + ", " + f.fireLongitude + ", " + f.fireArea);
            }
            return fireList;
        }

        public List<string> DisplayPictureInfo()
        {
            var pictures = from p in db.tblPictures
                           join s in db.tblStrikes
                           on p.strikeID equals s.strikeID
                           select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName};
            List<String> pictureList = new List<string>();
            foreach (var p in pictures)
            {
                pictureList.Add(p.strikeLatitude + ", " + p.strikeLongitude + ", " + p.pictureFileName);
            }
            return pictureList;
        }

        public List<string> FireByLightning()
        {
            var fires = from f in db.tblFires
                        select f;
            var lightnings = from s in db.tblStrikes
                             select s;
            List<String> fireList = new List<string>();
            foreach (var f in fires)
            {
                foreach (var l in lightnings)
                {
                    if (f.fireDate == l.strikeDate && f.fireLatitude == l.strikeLatitude && f.fireLongitude == l.strikeLongitude)
                    {
                        fireList.Add(f.fireDate + ", " + f.fireLatitude + ", " + f.fireLongitude + ", " + f.fireArea);
                    }
                }
            }
            return fireList;
        }

    }
}
