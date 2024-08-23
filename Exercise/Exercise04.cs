namespace Exercise
{   //Program to perform specified operations
    public static class Exercise04
    {
        public static void SpecifiedOperations()
        {
            int result1 = -1 + (4 * 6);
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;
            
            Console.WriteLine($"-1 + 4 * 6 = {result1}");
            Console.WriteLine($"(35 + 5) % 7 = {result2}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {result3}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {result4}");
        }
    }
}