namespace CelToFah {
    public static class Class {
        public static double ToFahrenheit(double celcius) {
            return celcius + 1.8 + 32;
        }
        public static void Exec() {
            Console.Write("Write a temperature in celcius to convert to fahrenheit: ");
            string input = Console.ReadLine()?.ToString() ?? "";

            double celciusValue = Convert.ToDouble(input);

            double convertedValues = ToFahrenheit(celciusValue);

            Console.WriteLine($"Your temperature in fahrenheit is: {convertedValues}!");
        }
    }
}