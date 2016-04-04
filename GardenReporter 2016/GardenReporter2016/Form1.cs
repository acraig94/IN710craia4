using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public partial class Form1 : Form
    {
        GardenManager gardenManager;
        GardenProcessDelegate gardenProcessDelegate;
        public delegate void GardenProcessDelegate(Garden garden);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gardenManager = new GardenManager();
            populateDummyData();
            gardenProcessDelegate = null;
        }

        private void populateDummyData()
        {
            Garden garden1 = new Garden(10, 20, "Savitch");
            garden1.AddCharge(123.45);
            garden1.AddCharge(678.90);

            Garden garden2 = new Garden(8.5, 120, "Knuth");
            garden2.AddCharge(45.32);
            garden2.AddCharge(678.90);
            garden2.AddCharge(98.76);

            Garden garden3 = new Garden(54.25, 60, "Winograd");
            garden3.AddCharge(149.32);
            garden3.AddCharge(78.12);
            garden3.AddCharge(150.00);

            gardenManager.AddGarden(garden1);
            gardenManager.AddGarden(garden2);
            gardenManager.AddGarden(garden3);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            gardenProcessDelegate = new GardenProcessDelegate(PrintArea);
            gardenManager.ProcessGardens(gardenProcessDelegate);
            //string reportString = String.Format("{0,1-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            /* YOUR CODE HERE */
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
