namespace EncapsulationDemo1702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person PersonOne = new Person("Jordan", 27, true);
            Person PersonTwo = new Person("Sarah", 22, false);

            Console.WriteLine(Person.Counter);

            Person P1 = new Person();
            Person P2 = new Person();

            Console.WriteLine(Person.Counter);

            //Console.WriteLine(PersonOne.GetName());


            //PersonOne.SetName("John");


            //Console.WriteLine(PersonOne.GetName());


            //Console.WriteLine(PersonOne);

        }
    }
}
