using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabase
{
    public partial class Form1 : Form
    {
        List<City> database;
        Func<String, int, List<City>, bool> search = (String s, int i, List<City> c) => s.Equals(c[i].CountryName);
        
        public Form1()
        {
            InitializeComponent();

            database = new List<City>();
            populateData();

        }

        public List<City> searchList(String s)
        {
            List<City> resultList = new List<City>();
            for (int i = 0; i < database.Count; i++)
            {
                bool result = search(s, i, database);
                if (result)
                {
                    resultList.Add(database[i]);
                }
            }
            return resultList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = textBox1.Text;
            List<City> results = searchList(s);
            foreach (City c in results)
            {
                listBox1.Items.Add(c.CityName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            updatePopulation();
        }

        public void updatePopulation()
        {
            database.ForEach(c => c.Population = c.Population * 3);
            database.ForEach(c => listBox1.Items.Add(c.ToString()));
        }

        public void populateData()
        {
            City a = new City("Budapest", "Hungary", 1757621);
            City b = new City("London", "England", 8534215);
            City c = new City("Leicester", "England", 333248);
            City d = new City("Barcelona", "Spain", 5362547);
            City e = new City("Madrid", "Spain", 7349000);
            City f = new City("Dortmund", "Germany", 4583000);

            database.Add(a);
            database.Add(b);
            database.Add(c);
            database.Add(d);
            database.Add(e);
            database.Add(f);
        }
        
    }
}
