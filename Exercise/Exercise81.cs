using System;
namespace  Exercise
{
    public static class Exercise81
    {
        public static void RemoveNonLetters()
        {
            string txt = "123 Hello World @#442.";
            string removed = new string(
                txt.Where(char.IsLetter).ToArray()
                );
            Console.WriteLine($"Removed Non - Letters: {removed}");
        }
    }
}