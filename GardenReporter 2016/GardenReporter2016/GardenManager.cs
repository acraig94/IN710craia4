using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        List<Garden> gardenList;
        ListBox listBox1;
        public delegate void GardenProcessDelegate(Garden garden);

        public GardenManager()
        {
            gardenList = new List<Garden>();
            //this.listBox1 = listBox1;
            //GardenProcessDelegate gardenProcessDelegate = null;
        }

        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }

        public void ProcessGardens(GardenProcessDelegate gardenprocessdelegate)
        {
            foreach (Garden garden in gardenList)
            {
                gardenprocessdelegate(garden);
            }            
        }

        public void PrintArea(Garden garden)
        {
            string reportString = String.Format("{0,1-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
            listBox1.Items.Add(reportString);
        }

        public void PrintCharges(Garden garden)
        {
            string reportString = String.Format("{0,1-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance());
            listBox1.Items.Add(reportString);
        }




    }
}
