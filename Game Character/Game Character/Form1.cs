using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        private List<Character> charactersList = new List<Character>();

        public Form1()
        {
            InitializeComponent();            
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string name;
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name");
                name = "Blank";
            }
            else
            {
                name = txtName.Text.ToString();
            }
            Character newCharacter = null;
            if (rdKing.Checked)
            {
                newCharacter = new King(listBox1, name);
            }
            if (rdQueen.Checked)
            {
                newCharacter = new Queen(listBox1, name);
            }
            if (rdKnight.Checked)
            {
                newCharacter = new Knight(listBox1, name);
            }
            if (rdTroll.Checked)
            {
                newCharacter = new Troll(listBox1, name);
            }
            charactersList.Add(newCharacter);
            refreshCharacterListBoxes();
            txtName.Clear();
        }

        public void refreshCharacterListBoxes()
        {
            characterBattleLB.Items.Clear();
            characterListBox.Items.Clear();

            foreach(Character c in charactersList)
            {
                characterBattleLB.Items.Add(c.getName());
                characterListBox.Items.Add(c.getName());            
            } 
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {            
            List<Character> selectedCharacters = new List<Character>();

            foreach(var i in characterBattleLB.SelectedItems)
            {
                selectedCharacters.Add((Character)i);
            }

            if (selectedCharacters.Count() == 2)
            {
                Character char1 = selectedCharacters.ElementAt(0);
                Character char2 = selectedCharacters.ElementAt(1);

                char1.printAll();
                listBox1.Items.Add("---------------------");
                char2.printAll();
               
            }


        }
    }
}
