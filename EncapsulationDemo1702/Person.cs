﻿using System.Diagnostics.Metrics;

namespace EncapsulationDemo1702
{
    public class Person
    {

        //attributes - describes what features make a person
        private string Name;
        private int Age;
        private bool IsMale;
        public static int Counter = 0;
        

        //constructors
        //default constructor
        public Person() { Counter++; }
        //everything constructor
        public Person(string Name, int Age, bool IsMale)
        {
            this.Name = Name;
            this.Age = Age;
            this.IsMale = IsMale;
            Counter++;
        }

        //Getters and setters
        //getter
        public string GetName()
        {
            return this.Name;
        }

        //setter
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        //any extra methods

        public void PrintSomething()
        {
            Console.WriteLine("Hello");
        }

        public static void PrintSomethingStatic()
        {
            Console.WriteLine("This is the static method");
        }


        //tostring
        public override string ToString()
        {
            //using string concatenation
            //return "This person is called " + this.Name + " and is " + this.Age
            //    + " years old. Are they male?" + this.IsMale;

            return $"This person is called {this.Name} and is {this.Age} years old, are they male? {this.IsMale}";
        }

    }
}
