using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    public class Cat : Animal
    {

        private bool HasClaws;

        public bool HasClaws1 { get => HasClaws; set => HasClaws = value; }

        public Cat() { }
        public Cat(int id, string colour, string species, bool hasFourLegs, bool hasClaws)
            : base(id, colour, species, hasFourLegs)
        {
            this.HasClaws1 = hasClaws;
        }
        public Cat(bool hasClaws)
        {
            HasClaws1 = hasClaws;
        }

        public override void noise()
        {
            Console.WriteLine("Meow meow");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n  Cat Features: \n  Does it have claws?: {HasClaws1}";
        }

        public override void play()
        {
            Console.WriteLine("I like to play with string");
        }

        public override double calculateBill()
        {
            return 10.99;
        }

        public override void RespondToCommand()
        {
            Console.WriteLine("pspspsps");
        }
    }
}
