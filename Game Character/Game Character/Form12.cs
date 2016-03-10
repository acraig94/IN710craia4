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
            charactersList.Add(new King(listBox1, "Stevie"));
            charactersList.Add(new Queen(listBox1, "Nix"));
            refreshCharacterListBoxes();
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
            List<int> selectedCharacters = new List<int>();
            /*
            foreach(int i in characterBattleLB.SelectedIndices)
            {
                selectedCharacters.Add(i);
            }

            if (selectedCharacters.Count() == 1)
            {*/
                Character char1 = charactersList[characterBattleLB.SelectedIndices[0]];
            //Character char2 = charactersList[characterBattleLB.SelectedIndices[1]];
                listBox1.Items.Clear();
                char1.printAll();
                listBox1.Items.Add("---------------------");
                char1.printAll();
            /*   
            }
            else
            {
                int i = selectedCharacters.Count();
                MessageBox.Show("Select 2 characters to battle " + i );
            }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character char1 = charactersList[characterListBox.SelectedIndices[0]];
            string newWeapon = null;
            if (rdSword.Checked)
            {
                char1.setWeapon(new Sword());
            }
            if (rdKnife.Checked)
            {
                char1.setWeapon(new Knife());
            }
            if (rdBow.Checked)
            {
                char1.setWeapon(new Bow());
            }
            /*if (newWeapon == null || char1 == null)
            {
                MessageBox.Show("Select a character and weapon to change too");
            }*/
        }
    }
}
