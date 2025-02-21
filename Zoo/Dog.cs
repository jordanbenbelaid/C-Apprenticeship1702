using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dog : Animal
    {
        //Attribute
        private string Name;

        //Constructor
        public Dog() { }
        public Dog(string name, int id, string colour, string species, bool hasFourLegs) 
            : base(id, colour, species, hasFourLegs)
        { 
            this.Name1 = name; 
        }

        //Getter and Setter
        public string Name1 { get => Name; set => Name = value; }

        //Methods
        //In the Animal class, we have a noise method. We have to add the keyword "virtual"
        //This allows us to then override the method in the Parent/Base class
        //and we can add our own implementation specifically for Dog
        public override void noise()
        {
            Console.WriteLine("Woof Bark");
        }

        //This is an example of method overloading
        //We use the same method name, but add different parameters to each
        //c# recognises this and allows us to have it as 2 different methods
        //Normally having the same method name is not allowed, unless they have different parameters
        //Constructor overloading is an example of this as well
        public void eat()
        {
            Console.WriteLine("This is good");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{food}");
        }

        //ToString
        public override string ToString()
        {
            return $"{base.ToString()} \n  Dog Features: \n  Name: {Name1}";
        }

        public override void play()
        {
            Console.WriteLine("I like to play fetch");
        }

        public override double calculateBill()
        {
            return 16.99;
        }

        public override void RespondToCommand()
        {
            Console.WriteLine("Sit");
        }
    }
}
