namespace EnumExerciseSolution
{
    public class Program

    {
        static void Main(string[] args)
        {
            // Assigning an enum value
            DaysOfWeek Day = DaysOfWeek.Monday;
            Console.WriteLine(Day);

            // Enum to integer conversion
            int numericValue = (int)Day;
            Console.WriteLine($"Numeric value of {Day} is: {numericValue}");

            // Integer to enum conversion
            DaysOfWeek dayFromNumber = (DaysOfWeek)3;
            Console.WriteLine($"The day represented by 3 is: {dayFromNumber}");

            // Using enum in a switch statement
            switch (Day)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("Start of the workweek.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("Almost the weekend!");
                    break;
                default:
                    Console.WriteLine("Just another day.");
                    break;
            }
        }
    }
}
