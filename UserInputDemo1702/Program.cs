namespace UserInputDemo1702
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name");

            string Name = Console.ReadLine();

            Console.WriteLine($"Hi {Name}, how are you?");

            Console.WriteLine("How old are you?");

            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hi {Name}, you are {Age} years old");


            Console.WriteLine("What year were you born");
            if(int.TryParse(Console.ReadLine(), out int YearOfBirth))
            {
                Console.WriteLine($"You were born in {YearOfBirth}");
            }
            else
            {
                Console.WriteLine("You have entered an invalid year");
            }

        }
    }
}
