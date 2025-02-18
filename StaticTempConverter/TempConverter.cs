namespace StaticTempConverter
{
    public static class TempConverter
    {

        // Static field to count the total number of conversions
        private static int ConversionCount = 0;

        // Static method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            ConversionCount++;
            return (celsius * 9 / 5) + 32;
        }

        // Static method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            ConversionCount++;
            return (fahrenheit - 32) * 5 / 9;
        }

        // Static method to print the total number of conversions
        public static void PrintConversionCount()
        {
            Console.WriteLine($"Total conversions performed: {ConversionCount}");
        }

    }
}
