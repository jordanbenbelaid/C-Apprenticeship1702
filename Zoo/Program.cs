namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Elephant = new Animal(1, "Grey", "African", true);

            Dog DogOne = new Dog("Doggo", 2, "Brown", "German Shepherd", true);

            //get using generated getters
            Console.WriteLine(Elephant.Colour1);

            //set using generated setters
            Elephant.Colour1 = "Blue";
            Console.WriteLine(Elephant.Colour1);

            Console.WriteLine(DogOne);

            List<Animal> AnimalList = new List<Animal>();

            AnimalList.Add(Elephant);
            AnimalList.Add(DogOne);
            
        }
    }
}
