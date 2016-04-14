using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateLambda
{
    public partial class Form1 : Form
    {
        Random rand;
        List<int> numberList;
        List<int> resultList;

        public Form1()
        {
            InitializeComponent();

            rand = new Random();
            numberList = new List<int>();
            resultList = new List<int>();

        }

        public delegate bool ChecksInt(int n);

        //public void filterNumbers(ChecksInt filter)
        //{
        //    foreach (int num in numberList)
        //    {
        //        bool result = filter(num);
        //        if (result)
        //        {
        //            resultList.Add(num);
        //        }
        //    }            
        //}

        public void filterNumbers(ChecksInt filter, int num)
        {          
            bool result = filter(num);
            if (result)
            {
                resultList.Add(num);
            } 
            
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
            numberList.Clear();
            for (int i = 0; i < 15; i++)
            {
                int n = rand.Next(50);
                numberList.Add(n);
            }
            updateListbox1();
        }

        private void btn_Even_Click(object sender, EventArgs e)
        {
            resultList.Clear();
            if (numberList.Count != 0)
            {               
                foreach (int n in numberList)
                {
                    filterNumbers((x) => x % 2 == 0, n);
                }
                updateListbox2();
            }
        }

        private void btn_Less_Click(object sender, EventArgs e)
        {
            resultList.Clear();
            if (numberList.Count != 0)
            {
                foreach (int n in numberList)
                {
                    filterNumbers((x) => x < 10, n);
                }
                updateListbox2();
            }
        }

        public void updateListbox1()
        {
            listBox1.Items.Clear();
            foreach (int n in numberList)
            {
                listBox1.Items.Add(n);
            }
        }

        public void updateListbox2()
        {
            listBox2.Items.Clear();
            foreach (int n in resultList)
            {
                listBox2.Items.Add(n);
            }
        }

    }
}
