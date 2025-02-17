namespace EncapsulationDemo1702
{
    public class Person
    {

        //attributes - describes what features make a person
        private string Name;
        private int Age;
        private bool IsMale;

        //constructors
        //default constructor
        public Person() { }
        //everything constructor
        public Person(string Name, int Age, bool IsMale)
        {
            this.Name = Name;
            this.Age = Age;
            this.IsMale = IsMale;
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
