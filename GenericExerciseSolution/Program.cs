namespace GenericExerciseSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<int> intRepo = new Repository<int>();
            intRepo.Add(1);
            intRepo.Add(2);
            intRepo.Add(3);
            Console.WriteLine("Integer Repository:");
            foreach (var item in intRepo.GetAll())
            {
                Console.WriteLine(item);
            }

            // Example with strings
            Repository<string> stringRepo = new Repository<string>();
            stringRepo.Add("Hello");
            stringRepo.Add("World");

            Console.WriteLine("\nString Repository:");
            foreach (var item in stringRepo.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
