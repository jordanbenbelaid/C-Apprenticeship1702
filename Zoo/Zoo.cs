using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {

        //Create a list (initialise a list)
        List<Animal> animals;

        //Constructor - Create the list inside of this constructor
        public Zoo()
        {
            this.animals = new List<Animal>();
        }

        //create a method to add the animals to the list
        public void AddAnimalToList(Animal animal)
        {
            this.animals.Add(animal);
        }

        //create a FindAnimalById method, so you can find an animal with the given id
        public Animal FindAnimalById(int id)
        {
            foreach (Animal a in this.animals)
            {
                if (a.Id1 == id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
