namespace AverageInventory
{
    public static class Class
    {
        private static int[] ParseInput(string input)
        {
            string[] parts = input.Split(',');

            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            return numbers;
        }
        private static double CalculateAverage(int minQuantity, int maxQuantity)
        {
            double parsedMin = Convert.ToDouble(minQuantity);
            double parsedMax = Convert.ToDouble(maxQuantity);

            double average = (parsedMin + parsedMax) / 2.0;

            return average;
        }
        public static void Exec()
        {
            Console.Write("Write the minimum value and the maximum value, separated by comm (like: '37, 90'): ");
            string input = Console.ReadLine()?.ToString() ?? "";

            int[] values = ParseInput(input);

            if (values.Length != 2)
            {
                Console.Write("You must write 2 numbers separated by comma! Try again in a new command.");

                return;
            }

            double averageInventory = CalculateAverage(values[0], values[1]);

            Console.WriteLine($"The average inventory is: {averageInventory}");
        }
    }
}