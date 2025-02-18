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
        public int Id1 { get => Id; set => Id = value; }
        public string Colour1 { get => Colour; set => Colour = value; }
        public string Species1 { get => Species; set => Species = value; }
        public bool HasFourLegs1 { get => HasFourLegs; set => HasFourLegs = value; }

        //Methods/Behaviours of the Class
        public void noise()
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
