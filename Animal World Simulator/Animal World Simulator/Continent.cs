using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_World_Simulator
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 4;

        protected ListBox displaybox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(ListBox displaybox, Random rGen, int nAnimalTypes, Graphics canvas)
        {
            this.displaybox = displaybox;
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        public void runSimulation()
        {
            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                int animalChoice = rGen.Next(nAnimalTypes);
                currentAnimal = animalFactory.createAnimal(animalChoice);

                displaybox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 90), 90, 90);
            }
        }

    }
}
