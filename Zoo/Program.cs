namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Elephant = new Animal(1, "Grey", "African", true);

            //get using generated getters
            Console.WriteLine(Elephant.Colour1);

            //set using generated setters
            Elephant.Colour1 = "Blue";
            Console.WriteLine(Elephant.Colour1);
        }
    }
}
