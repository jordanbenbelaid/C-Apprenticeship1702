namespace MethodDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyName("Jordan");

            //this wont print anything to the console
            //this method has a return type, so it returns a value, it doesnt print it
            //GetMyAge(27);

            Console.WriteLine(GetMyAge(27));

            //arrays
            string[] NamesWithValues = { "Jordan", "Cristiano", "Pilar", "Charlie"};
            int[] NumbersWithoutValues = new int[5];

            NumbersWithoutValues[0] = 3;
            NumbersWithoutValues[1] = 4;
            NumbersWithoutValues[2] = 5;
            NumbersWithoutValues[3] = 36;
            NumbersWithoutValues[4] = 37;


            //for loops
            //part 1 - initialisation/where are we starting from
            //part 2 - where are we ending (exit condition)
            //part 3 - increment the value of i each time the loop loops so we dont get an endless loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i*10);
            }

            //foreach loop, used for goign through collections like arrays, lists etc.
            foreach(string names in NamesWithValues)
            {
                Console.WriteLine(names);
            }
        }

        //void method with a parameter
        public static void MyName(string name) 
        {
            Console.WriteLine(name);
        }

        //return method with a parameter
        public static int GetMyAge(int age)
        {
            return age;
        }

        
    }
}
