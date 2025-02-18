namespace CollectionsAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> StringBox = new GenericClass<string>("Hello");
            GenericClass<int> IntegerBox = new GenericClass<int>(23);

            Console.WriteLine($"StringBox: {StringBox}");
            Console.WriteLine(StringBox.GetItem());

            Console.WriteLine($"IntegerBox: {IntegerBox}");
            Console.WriteLine(IntegerBox.GetItem());

            //list creation example
            List<string> StringList = new List<string>();
            StringList.Add("Jordan");
            StringList.Add("Pilar");
            StringList.Add("Matthew");
            StringList.Add("Cristiano");
            StringList.Add("Charlie");

            //printing all strings in the list using a foreach loop
            foreach(string s in StringList)
            {
                Console.WriteLine(s);
            }

            //printing all strings in the list using a normal for loop
            for(int i = 0; i < StringList.Count; i++)
            {
                Console.WriteLine(StringList[i]);
            }


            //LINQ example
            List<string> names = StringList.Where(n => n.StartsWith("C")).ToList();

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
