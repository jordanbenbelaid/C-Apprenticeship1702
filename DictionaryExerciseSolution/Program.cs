namespace DictionaryExerciseSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store student IDs and names
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add student IDs and names
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            students.Add(3, "Charlie");

            // Retrieve and print a student name using their ID
            //TryGetValue will try to get the value if the key exists, store the value in the variable name
            int idToFind = 2;
            if (students.TryGetValue(idToFind, out string name))
            {
                Console.WriteLine($"Student with ID {idToFind}: {name}");
            }
            else
            {
                Console.WriteLine($"No student found with ID {idToFind}");
            }

            // Print all students
            //var allows the data type to be inferred at compile time (use sparingly)
            //here, we could replace var with KeyValuePair<int,string> instead
            Console.WriteLine("\nAll students in the dictionary:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}
