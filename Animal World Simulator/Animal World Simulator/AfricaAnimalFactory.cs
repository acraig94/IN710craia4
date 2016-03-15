using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class AfricaAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Elephant();
                    break;
                case 1:
                    newAnimal = new Lion();
                    break;
            }
            return newAnimal;
        }
    }
}
