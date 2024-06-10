namespace OutKey {
    public static class Class {
        public static void Duplicate(out string value) {
            value = "modified";

            return;
        }
        public static void Exec() {
            string outValue = "original";

            Console.WriteLine($"The original value is: {outValue}");

            Duplicate(out outValue);

            Console.WriteLine($"The modified value is: {outValue}");
        }
    }
}