namespace Exercise
{
    //Program to swap the first and last character of a string
    public static class Exercise16
    {
        public static void SwapFirstAndLastCharFromString()
        {
            string text = "World";
            int len = text.Length;
            string swapped = text[len - 1] + text.Substring(1) + text[0];
            Console.WriteLine($"Swapped first and last character: {swapped}");
        }
    }
}