namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> WorldFoods = new Dictionary<string, string>();

            //List<string> List = new List<string>();
            //Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            WorldFoods.Add("Italy", "Pasta");
            WorldFoods.Add("Japan", "Ramen");
            WorldFoods.Add("America", "Hamburgers");

            Console.WriteLine($"Italy is known for {WorldFoods["Italy"]}");

            //string country = "Japan";

            //if (WorldFoods.ContainsKey(country))
            //{
            //    Console.WriteLine($"{country} is known for {WorldFoods[country]}");
            //} else
            //{
            //    Console.WriteLine($"{country} could not be found in the dictionary");
            //}

            foreach (KeyValuePair<string, string> kvp in WorldFoods)
            {
                Console.WriteLine($"Country: {kvp.Key}, Food: {kvp.Value}");
            }


            WorldFoods.Remove("America");

            foreach (KeyValuePair<string, string> kvp in WorldFoods)
            {
                Console.WriteLine($"Country: {kvp.Key}, Food: {kvp.Value}");
            }

            WorldFoods["Italy"] = "Pizza";

            Console.WriteLine($"Italy is known for {WorldFoods["Italy"]}");
        }
    }
}
