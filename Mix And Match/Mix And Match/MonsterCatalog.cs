using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_And_Match
{
    public class MonsterCatalog
    {

        string inputFileName;
        private List<Monster> monsterList;
        public List<Monster> MonsterList
        {
            get { return monsterList; }
        }

        public MonsterCatalog(string inputFileName)
        {
            this.inputFileName = inputFileName;
            monsterList = new List<Monster>();
            loadMonsterList();
        }

        private void loadMonsterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                //String[] currentMonster;


                while ((currentLine = sr.ReadLine()) != null)
                {
                    //currentMonster = currentLine;

                    EType currentSpecies = (EType)System.Enum.Parse(typeof(EType), currentLine);
                    monsterList.Add(new Monster(currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

    }
}
