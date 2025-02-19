using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {

        //Fields/Attributes
        private int Id;
        private string Colour;
        private string Species;
        private bool HasFourLegs;

        //Constructors
        public Animal() { }
        public Animal(int id, string colour, string species, bool hasFourLegs)
        {
            this.Id1 = id;
            this.Colour1 = colour;
            this.Species1 = species;
            this.HasFourLegs1 = hasFourLegs;
        }

        //Getters and Setters

        //Encapsulate fields (and use properties):
        //We access fields through properties (The generated getters and setters)
        //allows logic (validation etc) in the getters and setters
        //Flexible as it allows us to easily change implementation without breaking code
        //Can be a little slower due to the way it calls methods

        //Encapsulate fields (but using fields):
        //we access directly from fields or getter and setter methods
        //We have less control over how data is modified/accessed
        //harder to change data access (manual refactoring)
        //slightly faster, since its direct access

        public int Id1 { get => Id; set => Id = value; }
        public string Colour1 { get => Colour; set => Colour = value; }
        public string Species1 { get => Species; set => Species = value; }
        public bool HasFourLegs1 { get => HasFourLegs; set => HasFourLegs = value; }

        //Methods/Behaviours of the Class
        public virtual void noise()
        {
            Console.WriteLine("Animal noise");
        }

        //ToString
        public override string ToString()
        {
            return $"Animal: \nID: {Id1} \nColour: {Colour1} \n" +
                $"Species: {Species1} \nDoes it have 4 legs?: {HasFourLegs1}";
        }




    }
}
