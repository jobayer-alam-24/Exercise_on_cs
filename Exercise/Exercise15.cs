namespace Exercise
{
    //Program to remove specified char from string
    public static class Exercise15
    {
        public static void RemoveSpecifiedCharFromString(string input, char character)
        {
            int indexForChar = input.IndexOf(character);
            string cutted = input.Remove(indexForChar, 1);
            Console.WriteLine($"Removed char: {cutted}");
        }
    }
}