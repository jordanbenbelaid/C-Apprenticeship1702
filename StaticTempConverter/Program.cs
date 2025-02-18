namespace StaticTempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert Celsius to Fahrenheit
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is {fahrenheit}°F");

            // Convert Fahrenheit to Celsius
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheitInput = double.Parse(Console.ReadLine());
            double celsiusConverted = TempConverter.FahrenheitToCelsius(fahrenheitInput);
            Console.WriteLine($"{fahrenheitInput}°F is {celsiusConverted}°C");

            // Print the total number of conversions
            TempConverter.PrintConversionCount();
        }
    }
}
