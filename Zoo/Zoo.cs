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
            Console.WriteLine("Animal added");
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

        //calculate bill by id
        public void calculateBillById(int id)
        {
            foreach (Animal a in this.animals)
            {
                if (a.Id1 == id)
                {
                    Console.WriteLine($"The bill for this animal is {a.calculateBill()}");
                }
            }
        }

        //calculate bill of whole zoo
        public void calculateTotalBillOfZoo()
        {
            double total = 0;
            foreach(Animal a in this.animals)
            {
                total += a.calculateBill();
            }
            Console.WriteLine($"The total bill of this zoo is {total}");
        }

        //calculate bill based on type of animal
        public void calculateBillByType(Animal animal)
        {
            double total = 0;
            foreach(Animal a in this.animals)
            {
                if(a.GetType() == animal.GetType())
                {
                    total += a.calculateBill();
                }
            }
            Console.WriteLine($"The total for all {animal.GetType().Name}s is {total}");
        }
        
    }
}
