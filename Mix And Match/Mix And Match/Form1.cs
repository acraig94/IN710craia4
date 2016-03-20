using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_And_Match
{
    public partial class Form1 : Form
    {
        private const string inputFile = "monsterList.txt";
        
        private MonsterCatalog headCatalog;
        private MonsterCatalog bodyCatalog;
        private MonsterCatalog legCatalog;
        
        private List<Monster> headTypes;
        private List<Monster> bodyTypes;
        private List<Monster> legTypes;

        private ImagePrinter printer;

        public Form1()
        {
            InitializeComponent();

            headCatalog = new MonsterCatalog(inputFile);
            bodyCatalog = new MonsterCatalog(inputFile);
            legCatalog = new MonsterCatalog(inputFile);

            headTypes = headCatalog.MonsterList;
            bodyTypes = bodyCatalog.MonsterList;
            legTypes = legCatalog.MonsterList;

            cb_Head.DataSource = headTypes;
            cb_Head.DisplayMember = "Type";

            cb_Body.DataSource = bodyTypes;
            cb_Body.DisplayMember = "Type";

            cb_Leg.DataSource = legTypes;
            cb_Leg.DisplayMember = "Type";

            printer = new ImagePrinter(cb_Head, cb_Body, cb_Leg, pictureBox1, pictureBox2, pictureBox3);
        }


        private void btn_Make_Click(object sender, EventArgs e)
        {
            printer.printMonster();            
        }
    }
}
